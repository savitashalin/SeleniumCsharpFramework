using ExcelDataReader;
using System.Data;

namespace CommonUtilities.DataHelper
{
    public class ExcelOperations
    {
        public static List<DataCollection> dataCollection = new List<DataCollection>();
        private static DataTable ReadExcelData()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            string FileName = @"D:\\SeleniumTestProjectSavita\\CommonUtilities\\TestData\\TestData.xlsx";
            FileStream fileStream = File.Open(FileName , FileMode.Open, FileAccess.Read);
            IExcelDataReader  excelreader = ExcelReaderFactory.CreateOpenXmlReader(fileStream);
            DataSet dataSet = excelreader.AsDataSet();
            DataTableCollection table = dataSet.Tables;
            DataTable resultTable = table["Sheet1"];
            return resultTable;
        }

        public static void PopulateInCollection()
        {
            DataTable dt = ReadExcelData();
            for (int r = 0; r < dt.Rows.Count; r++) 
            {
                for(int c =0; c < dt.Columns.Count; c++)
                {
                    DataCollection dtCollection = new DataCollection()
                    {
                        rownumber = r,
                        colName = dt.Columns[c].ColumnName,
                        colValue = dt.Rows[r][c].ToString()
                    };

                    dataCollection.Add(dtCollection);
                }
            }
        }

        public static string ReadData(int rowNumber, string colName)
        {
            PopulateInCollection();
            try 
            {
                string data = (from colData in dataCollection
                                where colData.colName == colName && colData.rownumber == rowNumber
                                select colData.colValue).SingleOrDefault();

                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public class DataCollection
        {
            public int rownumber { get; set; }
            public string colName { get; set; }
            public string colValue { get; set; }
        }
    }
}
