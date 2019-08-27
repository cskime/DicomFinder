using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Dicom;
using DicomFInder.Extensions;

namespace DicomFInder.Dataset
{ 
    public class DCM
    {
        private Dictionary<string, string> dataset = new Dictionary<string, string>();

        public DCM(FileInfo file)
        {
            DicomFile dicom = DicomFile.Open(file.FullName);
            setDICOMInfo(dicom);
        }

        private void setDICOMInfo(DicomFile dcmFile)
        {
            dataset[Columns.name.ToString()] = dcmFile.Dataset.GetValue<string>(DicomTag.PatientName, 0).decode("ISO-8859-1", 51949);
            dataset[Columns.ID.ToString()] = dcmFile.Dataset.GetValue<string>(DicomTag.PatientID, 0);
            dataset[Columns.birth.ToString()] = dcmFile.Dataset.GetValue<string>(DicomTag.PatientBirthDate, 0);
            dataset[Columns.studydate.ToString()] = dcmFile.Dataset.GetValue<string>(DicomTag.StudyDate, 0);
            dataset[Columns.dcmpath.ToString()] = dcmFile.Dataset.GetValue<string>(DicomTag.PatientName, 0);
        }

        public bool find(string key ,string value)
        {
            bool isExist = dataset.Where(data => dataset[key].Equals(value)).Count() != 0;
            return isExist;
        }

        public Dictionary<string, string> getDataset()
        {
            return dataset;
        }

        public string getData(string key)
        {
            string value;
            if (dataset.TryGetValue(key, out value))
                return value;
            else
                return null;
        }
    }
}
