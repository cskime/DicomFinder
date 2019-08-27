using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DicomFInder.Dataset;
using Excel = Microsoft.Office.Interop.Excel;

namespace DicomFInder
{
    public partial class Form1 : Form
    {
        private BaseData basedata = new BaseData();

        public Form1()
        {
            InitializeComponent();

            searchTxt_ID.Tag = Columns.ID.ToString();
            searchTxt_Name.Tag = Columns.name.ToString();
            searchTxt_Birth.Tag = Columns.birth.ToString();
            searchTxt_Date.Tag = Columns.studydate.ToString();
        }

        private void PathBtn_Click(object sender, EventArgs e)
        {
            using (var dir = new FolderBrowserDialog())
            {
                DialogResult result = dir.ShowDialog();
                if (result.Equals(DialogResult.OK))
                {
                    pathTextBox.Text = dir.SelectedPath.Trim();
                }
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            stateTxt.Text = "Find file...";

            string[] dcmFiles = Directory.GetFiles(pathTextBox.Text, "*.dcm", SearchOption.AllDirectories);
            string[] mcsFiles = Directory.GetFiles(pathTextBox.Text, "*.mcs", SearchOption.AllDirectories);
            basedata.setData(dcmFiles, mcsFiles);

            stateTxt.Text = "Finish";
            dcmCountTxt.Text = $"DCM : {dcmFiles.Length} files";
            mcsCountTxt.Text = $"MCS : {mcsFiles.Length} files";
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            resultTable.Clear();
            updateResult();
        }

        private void updateResult()
        {
            // Set Header
            resultTable.Columns.Add(Columns.ID.ToString(), 100, HorizontalAlignment.Center);
            resultTable.Columns.Add(Columns.name.ToString(), 100, HorizontalAlignment.Center);
            resultTable.Columns.Add(Columns.birth.ToString(), 100, HorizontalAlignment.Center);
            resultTable.Columns.Add(Columns.studydate.ToString(), 100, HorizontalAlignment.Center);
            resultTable.Columns.Add(Columns.dcmpath.ToString(), 100, HorizontalAlignment.Center);

            // search key
            Dictionary<string, string> searchSet = new Dictionary<string, string>();
            searchSet.Add(searchTxt_ID.Tag.ToString(), searchTxt_ID.Text);
            searchSet.Add(searchTxt_Name.Tag.ToString(), searchTxt_Name.Text);
            searchSet.Add(searchTxt_Birth.Tag.ToString(), searchTxt_Birth.Text);
            searchSet.Add(searchTxt_Date.Tag.ToString(), searchTxt_Date.Text);

            // Add rows
            List<Dictionary<string, string>> resultList = basedata.search(searchSet);
            resultList = resultList.Select(result =>
            {
                ListViewItem item = new ListViewItem(result[Columns.ID.ToString()]);
                item.SubItems.Add(result[Columns.name.ToString()]);
                item.SubItems.Add(result[Columns.birth.ToString()]);
                item.SubItems.Add(result[Columns.studydate.ToString()]);
                item.SubItems.Add(result[Columns.dcmpath.ToString()]);
                resultTable.Items.Add(item);
                return result;
            }).ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Save File
            using (var saveDlg = new SaveFileDialog())
            {
                saveDlg.Title = "Save File..";
                saveDlg.OverwritePrompt = false;
                saveDlg.Filter = basedata.getSaveFilter();

                if (saveDlg.ShowDialog().Equals(DialogResult.OK))
                    basedata.save(saveDlg.FileName);
            }
        }
    }
}
