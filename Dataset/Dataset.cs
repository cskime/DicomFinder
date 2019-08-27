using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace DicomFInder.Dataset
{

    public enum Columns
    {
        ID, name, birth, studydate, dcmpath, mcspath, filesize
    }

    public class BaseData
    {
        private List<DCM> dcmset = new List<DCM>();
        private List<MCS> mcsset = new List<MCS>();

        public void setData(string[] dcmFiles, string[] mcsFiles)
        {
            var files = dcmFiles.Select(file =>
            {
                dcmset.Add(new DCM(new FileInfo(file)));
                return file;
            }).ToArray();

            files = mcsFiles.Select(file =>
            {
                mcsset.Add(new MCS(new FileInfo(file)));
                return file;
            }).ToArray();
        }

        private void createDCMTable()
        {
            string[,] baseTable = new string[dcmset.Count, 5];
            dcmset.Select((dcm, index) =>
            {
                baseTable[index, 0] = dcm.getData(Columns.ID.ToString());
                baseTable[index, 1] = dcm.getData(Columns.name.ToString());
                baseTable[index, 2] = dcm.getData(Columns.birth.ToString());
                baseTable[index, 3] = dcm.getData(Columns.studydate.ToString());
                baseTable[index, 4] = dcm.getData(Columns.dcmpath.ToString());
                return dcm;
            });
        }

        public List<Dictionary<string, string>> search(Dictionary<string, string> input)
        {
            List<Dictionary<string, string>> resultTable = dcmset
                .Where(dcm =>
                {
                    bool isExist = true;
                    var buffer = input
                    .Where(kvp => !string.IsNullOrEmpty(kvp.Value))
                    .Where(kvp => isExist &= dcm.find(kvp.Key, kvp.Value));
                    return isExist;
                })
                .Select(dcm => dcm.getDataset())
                .ToList();
            return resultTable;
        }

        public string getSaveFilter()
        {
            return "Excel File(*.xlsx)|.xlsx";
        }
    
        public void save(string filename)
        {
            // Create New Excel FIle
            Excel.Application app = new Excel.Application();
            Excel.Workbook wb = app.Workbooks.Add();
            Excel.Worksheet ws = wb.Worksheets.Item["Sheet1"];

            writeDCM(ws);
            writeMCS(ws);

            wb.SaveAs(filename);
            wb.Close();
        }

        private void writeDCM(Excel.Worksheet ws)
        {
            // header
            ws.Cells[1, 1] = "DCM";
            ws.Cells[2, 1] = Columns.ID.ToString();
            ws.Cells[2, 2] = Columns.name.ToString();
            ws.Cells[2, 3] = Columns.birth.ToString();
            ws.Cells[2, 4] = Columns.studydate.ToString();
            ws.Cells[2, 5] = Columns.dcmpath.ToString();

            // data
            var set = dcmset.Select((dcm, index) =>
            {
                ws.Cells[index + 3, 1] = dcm.getData(Columns.ID.ToString());
                ws.Cells[index + 3, 2] = dcm.getData(Columns.name.ToString());
                ws.Cells[index + 3, 3] = dcm.getData(Columns.birth.ToString());
                ws.Cells[index + 3, 4] = dcm.getData(Columns.studydate.ToString());
                ws.Cells[index + 3, 5] = dcm.getData(Columns.dcmpath.ToString());
                return dcm;
            }).ToList();

            // alignment
            ws.Range[ws.Cells[1, 1], ws.Cells[dcmset.Count + 2, 5]].EntireColumn.AutoFit();
        }
        
        private void writeMCS(Excel.Worksheet ws)
        {
            // header
            ws.Cells[1, 7] = "MCS";
            ws.Cells[2, 7] = Columns.ID.ToString();
            ws.Cells[2, 8] = Columns.name.ToString();
            ws.Cells[2, 9] = Columns.birth.ToString();
            ws.Cells[2, 10] = Columns.mcspath.ToString();
            ws.Cells[2, 11] = Columns.filesize.ToString();

            // data
            var set = mcsset.Select((mcs, index) =>
            {
                ws.Cells[index + 3, 1] = mcs.getData(Columns.ID.ToString());
                ws.Cells[index + 3, 2] = mcs.getData(Columns.name.ToString());
                ws.Cells[index + 3, 3] = mcs.getData(Columns.birth.ToString());
                ws.Cells[index + 3, 4] = mcs.getData(Columns.mcspath.ToString());
                ws.Cells[index + 3, 5] = mcs.getData(Columns.filesize.ToString());
                return mcs;
            });

            // alignment
            ws.Range[ws.Cells[1, 1], ws.Cells[mcsset.Count + 2, 5]].EntireColumn.AutoFit();
        }
    }
}