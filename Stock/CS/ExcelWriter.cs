using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public class ExcelWriter
    {
        ///<summary>
        ///私有成員
        ///</summary>
        private HSSFWorkbook n_objBook;

        private HSSFSheet n_objSheet;

        private HSSFRow n_objHeadRow;

        //private HSSFRow n_objTitleRow;

        private HSSFDataFormat n_objDataformat;

        private HSSFCellStyle n_objCellStyle;

        ///<summary>
        ///數據表到Excel
        ///</summary>
        ///<param name="fileName">存儲文件的文件名</param>
        ///<param name="dgv">DataGridView</param>
        ///<param name="InforDataTable">DataTable</param>
        public void DataGridViewToExcel(string fileName, DataGridView dgv, DataTable InforDataTable)
        {
            //不導出空表
            if (dgv.Rows.Count == 0)
            {
                return;
            }
            SaveFileDialog saveFlie = new SaveFileDialog();
            saveFlie.DefaultExt = "xls";
            saveFlie.Filter = "Excel 2007格式|*.xls";
            saveFlie.FileName = Application.StartupPath + @"\Excel\" + fileName + ".xls";

            //Excel操作對象
            n_objBook = new HSSFWorkbook();
            n_objSheet = (HSSFSheet)n_objBook.CreateSheet(fileName);
            n_objHeadRow = (HSSFRow)n_objSheet.CreateRow(0);
            //n_objHeadRow = (HSSFRow)n_objSheet.CreateRow(1);
            n_objDataformat = (HSSFDataFormat)n_objBook.CreateDataFormat();
            n_objCellStyle = (HSSFCellStyle)n_objBook.CreateCellStyle();


            //Title
            //for (int i = 0; i < Title.Length; ++i)
            //{
            //    HSSFCell TitelCell = (HSSFCell)n_objTitleRow.CreateCell(i, CellType.String);
            //    TitelCell.SetCellValue(Title[i]);
            //}


            //表頭
            for (int i = 0; i < dgv.Columns.Count; ++i)
            {
                HSSFCell headCell = (HSSFCell)n_objHeadRow.CreateCell(i, CellType.String);
                headCell.SetCellValue(dgv.Columns[i].HeaderText);
            }

            //數據寫入
            for (int i = 0; i < dgv.Rows.Count; ++i)
            {
                HSSFRow n_Row = (HSSFRow)n_objSheet.CreateRow(i + 1);

                for (int j = 0; j < dgv.Columns.Count; ++j)
                {

                    HSSFCell cell = (HSSFCell)n_Row.CreateCell(j);
                    string valueType = InforDataTable.Rows[i][j].GetType().ToString();
                    string value = InforDataTable.Rows[i][j].ToString();

                    //指定數據的類型並賦值，採用TryParse進行強制轉換
                    switch (valueType)
                    {

                        case "System.String":
                            n_Row.CreateCell(j).SetCellValue(value);
                            break;
                        case "System.DateTime":
                            System.DateTime dateValue;
                            System.DateTime.TryParse(value, out dateValue);
                            //MessageBox.Show("i="+i.ToString()+"j="+j.ToString()+"value="+value.ToString());
                            n_Row.CreateCell(j).SetCellValue(dateValue);
                            n_objCellStyle.DataFormat = n_objDataformat.GetFormat("yyyy/MM/dd HH:mm:ss");//設置日期類型數據列的單元格格式
                            n_Row.Cells[j].CellStyle = n_objCellStyle;
                            break;
                        case "System.Boolean":
                            bool boolValue = false;
                            bool.TryParse(value, out boolValue);
                            n_Row.CreateCell(j).SetCellValue(boolValue);
                            break;
                        case "System.Int16":
                        case "System.Int32":
                        case "System.Int64":
                        case "System.Byte":
                            int intValue = 0;
                            int.TryParse(value, out intValue);
                            n_Row.CreateCell(j).SetCellValue(intValue);
                            break;
                        case "System.Decimal":
                        case "System.Double":
                            double doubleValue = 0;
                            double.TryParse(value, out doubleValue);
                            n_Row.CreateCell(j).SetCellValue(doubleValue);
                            break;
                        case "System.DBNull":
                            n_Row.CreateCell(j).SetCellValue("");
                            break;
                        default:
                            n_Row.CreateCell(j).SetCellValue("");
                            break;
                    }
                }
            }
            //設置各列自動適應單元個字符長度
            for (int i = 0; i < dgv.Columns.Count; ++i)
            {
                n_objSheet.AutoSizeColumn(i);
            }
            //寫入操作異常檢測，檢測文件是否被佔用
            try
            {
                using (FileStream fs = new FileStream(saveFlie.FileName, FileMode.Create))
                {
                    n_objBook.Write(fs);//寫入

                    fs.Close();//關閉數據流

                    GC.Collect();//垃圾回收（銷燬數據流）
                }
                MessageBox.Show("匯出成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {   ///異常報出有待改善
                MessageBox.Show("文件“" + fileName + "”正在被另一程序佔用", "錯誤提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }

        public void SmartPickToExcel(string fileName, List<Model.MS1.SmartExcelResult> SmartData)
        {
            string[] Header = new string[] { "代號", "名稱", "價位", "  ", "停利", "停損", "張數", "總價", "  ", "周轉", "成交金額", "漲停" };

            // 新建一個工作簿，獲取第一個工作表
            Workbook workbook = new Workbook();
            Worksheet sheet = workbook.Worksheets[0];
            workbook.ActiveSheetIndex = 0;

            // 初始化currentRow、currentFormula
            int HeaderRow = 1;
            string currentFormula = string.Empty;
            // 表頭
            for (int i = 0; i < Header.Length; ++i)
                sheet.Range[HeaderRow, i + 1].Value = Header[i];

            // 數據寫入
            for (int i = 0; i < SmartData.Count(); i++)
            {
                int currentRow = i + 2;

                sheet.Range[currentRow, 1].Text = SmartData[i].Id;
                sheet.Range[currentRow, 2].Text = SmartData[i].Name;
                sheet.Range[currentRow, 3].NumberValue = Convert.ToDouble(SmartData[i].Close);
                currentFormula = $"=FLOOR(C{currentRow}*1.1,LOOKUP(C{currentRow}" + "*1.1,{0,10,50,100,500},{0.01,0.05,0.1,0.5,1}))";
                sheet.Range[currentRow, 4].Formula = currentFormula;
                currentFormula = $"=CEILING(C{currentRow}*0.9,LOOKUP(C{currentRow}" + "*0.9,{0,10,50,100,500},{0.01,0.05,0.1,0.5,1}))";
                sheet.Range[currentRow, 5].Formula = currentFormula;
                currentFormula = $"=IF(D{currentRow}<10,D{currentRow}-0.05,IF(D{currentRow}<50,D{currentRow}-0.25,IF(D{currentRow}<100,D{currentRow}-0.5,IF(D{currentRow}<500,D{currentRow}-2.5,IF(D{currentRow}<1000,D{currentRow}-5,0)))))";
                sheet.Range[currentRow, 6].Formula = currentFormula;
                sheet.Range[currentRow, 7].NumberValue = 0;
                currentFormula = $"=C{currentRow}*G{currentRow}";
                sheet.Range[currentRow, 8].Formula = currentFormula;
                sheet.Range[currentRow, 9].Text = "  ";
                sheet.Range[currentRow, 10].NumberValue = Convert.ToDouble(SmartData[i].TurnoverRate);
                sheet.Range[currentRow, 11].Text = SmartData[i].DealPrice;
                if (Convert.ToDouble(SmartData[i].MaxPrice) == Convert.ToDouble(SmartData[i].Close))
                    sheet.Range[currentRow, 12].Style.KnownColor = ExcelColors.Red;
            }
            currentFormula = $"=SUM(H2:H{SmartData.Count() + 1})";
            sheet.Range[SmartData.Count() + 2, 8].Formula = currentFormula;
            currentFormula = $"=SUM(M2:M{SmartData.Count() + 1})";
            sheet.Range[SmartData.Count() + 2, 13].Formula = currentFormula;

            // 設定欄位背景及文字顏色
            sheet.Range[SmartData.Count() + 2, 8].Style.KnownColor = ExcelColors.Gray25Percent;
            sheet.Range[SmartData.Count() + 2, 8].Style.Font.Color = Color.Red;
            sheet.Range[SmartData.Count() + 2, 13].Style.KnownColor = ExcelColors.Gray25Percent;
            sheet.Range[SmartData.Count() + 2, 13].Style.Font.Color = Color.Red;

            // 設置列寬
            sheet.SetColumnWidth(11, 15);
            // 隱藏欄位D
            sheet.HideColumn(4);

            try
            {
                workbook.SaveToFile(Application.StartupPath + @"\Excel\SmartPicker\" + fileName + ".xlsx", FileFormat.Version2013);
                MessageBox.Show("匯出成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("文件“" + fileName + "”正在被另一程序佔用", "錯誤提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OrderToExcel(string fileName, List<Model.MS1.S1SmartOrder> OrderData)
        {
            string[] Header = new string[] { "代號", "名稱", "(入)買賣別", "委託價", "委託量", "委託條件", "委託類型", "MIT", "MIT買賣別", "MIT觸發價", "MIT當前市價", "停損", "(損)委託條件", "(損)%", "(損)%值", "(損)觸發價", "(損)觸發價值", "(損)限價", "(損)限價值", "(損)市價", "停利", "(利)委託條件", "(利)%", "(利)%值", "(利)觸發價", "(利)觸發價值", "(利)限價", "(利)限價值", "(利)市價", "出清", "出清時間", "(清)委託條件", "(清)限價", "(清)限價值", "(清)市價", "盤後定盤" };

            // 新建一個工作簿，獲取第一個工作表
            Workbook workbook = new Workbook();
            Worksheet sheet = workbook.Worksheets[0];
            workbook.ActiveSheetIndex = 0;

            // 初始化currentRow、currentFormula
            int HeaderRow = 1;
            string currentFormula = string.Empty;
            // 表頭
            for (int i = 0; i < Header.Length; ++i)
                sheet.Range[HeaderRow, i + 1].Value = Header[i];
            int row = 0;
            // 數據寫入
            foreach (var item in OrderData)
            {
                int currentRow = row + 2;
                sheet.Range[currentRow, 1].Text = item.in_Id;
                sheet.Range[currentRow, 2].Text = item.in_Name;
                sheet.Range[currentRow, 3].Text = item.in_BuySell.ToString();
                sheet.Range[currentRow, 4].Text = item.in_Price;
                sheet.Range[currentRow, 5].Text = item.in_Qty;
                sheet.Range[currentRow, 6].Text = item.in_Condition.ToString();
                sheet.Range[currentRow, 7].Text = item.in_Type.ToString();
                sheet.Range[currentRow, 8].Text = item.MIT.ToString();
                sheet.Range[currentRow, 9].Text = item.mit_BuySell;
                sheet.Range[currentRow, 10].Text = item.mit_TriggerPrice;
                sheet.Range[currentRow, 11].Text = item.mit_MarketPrice;
                sheet.Range[currentRow, 12].Text = item.Loss.ToString();
                sheet.Range[currentRow, 13].Text = item.loss_Condition.ToString();
                sheet.Range[currentRow, 14].Text = item.loss_Percent.ToString();
                sheet.Range[currentRow, 15].Text = item.loss_Percent_value;
                sheet.Range[currentRow, 16].Text = item.loss_TriggerPrice.ToString();
                sheet.Range[currentRow, 17].Text = item.loss_TriggerPrice_value;
                sheet.Range[currentRow, 18].Text = item.loss_DefinePrice.ToString();
                sheet.Range[currentRow, 19].Text = item.loss_DefinePrice_value;
                sheet.Range[currentRow, 20].Text = item.loss_MarketPrice.ToString();
                sheet.Range[currentRow, 21].Text = item.Earn.ToString();
                sheet.Range[currentRow, 22].Text = item.earn_Condition.ToString();
                sheet.Range[currentRow, 23].Text = item.Earn_Percent.ToString();
                sheet.Range[currentRow, 24].Text = item.Earn_Percent_value;
                sheet.Range[currentRow, 25].Text = item.earn_TriggerPrice.ToString();
                sheet.Range[currentRow, 26].Text = item.earn_TriggerPrice_value;
                sheet.Range[currentRow, 27].Text = item.earn_DefinePrice.ToString();
                sheet.Range[currentRow, 28].Text = item.earn_DefinePrice_value;
                sheet.Range[currentRow, 29].Text = item.earn_MarketPrice.ToString();
                sheet.Range[currentRow, 30].Text = item.Clear.ToString();
                sheet.Range[currentRow, 31].Text = item.c_Time;
                sheet.Range[currentRow, 32].Text = item.c_Condition.ToString();
                sheet.Range[currentRow, 33].Text = item.c_DefinePrice.ToString();
                sheet.Range[currentRow, 34].Text = item.c_DefinePrice_value;
                sheet.Range[currentRow, 35].Text = item.c_MarketPrice.ToString();
                sheet.Range[currentRow, 36].Text = item.FinalSet.ToString();
                row++;
            }

            try
            {
                workbook.SaveToFile(Application.StartupPath + @"\Excel\Order\Order" + fileName + ".xlsx", FileFormat.Version2013);
                MessageBox.Show("匯出成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("文件“" + fileName + "”正在被另一程序佔用", "錯誤提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
