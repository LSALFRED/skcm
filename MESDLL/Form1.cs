﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MESDLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strJson = "[{\"lstSerialNo\":null,\"OutStockID\":0.0,\"MaterialNo\":\"10013417\",\"MaterialDesc\":\"21003玛丽佳人多用美目胶水-白胶12ml\",\"RowNo\":\"1\",\"Plant\":null,\"PlantName\":null,\"ToStorageLoc\":null,\"Unit\":\"PCS\",\"UnitName\":null,\"OutStockQty\":3.0,\"OldOutStockQty\":0.0,\"RemainQty\":0.0,\"Costcenter\":null,\"Wbselem\":null,\"FromStorageLoc\":null,\"ReviewStatus\":null,\"CloseOweUser\":null,\"CloseOweDate\":null,\"CloseOweRemark\":null,\"IsOweClose\":null,\"OweRemark\":null,\"OweRemarkUser\":null,\"OweRemarkDate\":null,\"OKSelect\":false,\"VoucherNo\":\"F201908023874\",\"BatchNo\":null,\"IsSerial\":0,\"PartNo\":null,\"RowNoDel\":\"1\",\"StockQty\":0.0,\"lstStock\":null,\"ScanQty\":0.0,\"CustomerCode\":null,\"CustomerName\":null,\"PalletNo\":null,\"FromBatchNo\":\"201903210013\",\"FromErpAreaNo\":\"\",\"FromErpWarehouse\":\"MS001\",\"ToBatchno\":\"\",\"ToErpAreaNo\":\"\",\"ToErpWarehouse\":\"\",\"PostUser\":null,\"SourceVoucherNo\":\"\",\"SourceRowNo\":\"\",\"IsSpcBatch\":\"N\",\"StrIsSpcBatch\":\"否\",\"SouStrongHoldCode\":null,\"ID\":11431,\"HeaderID\":9430,\"OrderNumber\":\"1\",\"Status\":0,\"EditText\":\"编辑\",\"StrStatus\":null,\"DateFrom\":null,\"DateTo\":null,\"Creater\":\"admin\",\"CreateTime\":\"2019-08-02T17:26:22\",\"StrCreateTime\":null,\"Modifyer\":null,\"ModifyTime\":null,\"Auditor\":null,\"AuditorTime\":null,\"RowVersion\":null,\"TerminateReasonID\":null,\"TerminateReason\":null,\"LineStatus\":null,\"DisplayID\":null,\"DisplayName\":null,\"InitFlag\":null,\"StrModifyTime\":null,\"TimeStamp\":null,\"StrVoucherType\":null,\"StrCreater\":null,\"VoucherType\":24,\"TaskNo\":null,\"StrLineStatus\":null,\"MaterialNoID\":2,\"MaterialDoc\":null,\"DocDate\":null,\"PostDate\":null,\"StrongHoldCode\":\"FY2\",\"StrongHoldName\":\"义乌菲扬\",\"CompanyCode\":\"10\",\"ERPCreater\":null,\"VouDate\":null,\"VouUser\":null,\"DepartmentCode\":null,\"DepartmentName\":null,\"ERPStatus\":null,\"ERPStatusCode\":null,\"ERPNote\":null,\"ErpLineStatus\":0,\"EDate\":\"0001-01-01T00:00:00\",\"StrEDate\":null,\"StockType\":0,\"ErpVoucherNo\":\"FY2-HH2-1907310001\",\"PrintIPAdress\":null,\"ERPVoucherType\":\"HH2\",\"StrModifyer\":null,\"OperUserNo\":null,\"MainTypeCode\":null},{\"lstSerialNo\":null,\"OutStockID\":0.0,\"MaterialNo\":\"10013417\",\"MaterialDesc\":\"21003玛丽佳人多用美目胶水-白胶12ml\",\"RowNo\":\"2\",\"Plant\":null,\"PlantName\":null,\"ToStorageLoc\":null,\"Unit\":\"PCS\",\"UnitName\":null,\"OutStockQty\":12.0,\"OldOutStockQty\":0.0,\"RemainQty\":0.0,\"Costcenter\":null,\"Wbselem\":null,\"FromStorageLoc\":null,\"ReviewStatus\":null,\"CloseOweUser\":null,\"CloseOweDate\":null,\"CloseOweRemark\":null,\"IsOweClose\":null,\"OweRemark\":null,\"OweRemarkUser\":null,\"OweRemarkDate\":null,\"OKSelect\":false,\"VoucherNo\":\"F201908023874\",\"BatchNo\":null,\"IsSerial\":0,\"PartNo\":null,\"RowNoDel\":\"1\",\"StockQty\":0.0,\"lstStock\":null,\"ScanQty\":0.0,\"CustomerCode\":null,\"CustomerName\":null,\"PalletNo\":null,\"FromBatchNo\":\"201904260001\",\"FromErpAreaNo\":\"2C06010201\",\"FromErpWarehouse\":\"MS001\",\"ToBatchno\":\"\",\"ToErpAreaNo\":\"\",\"ToErpWarehouse\":\"\",\"PostUser\":null,\"SourceVoucherNo\":\"\",\"SourceRowNo\":\"\",\"IsSpcBatch\":\"N\",\"StrIsSpcBatch\":\"否\",\"SouStrongHoldCode\":null,\"ID\":11432,\"HeaderID\":9430,\"OrderNumber\":\"2\",\"Status\":0,\"EditText\":\"编辑\",\"StrStatus\":null,\"DateFrom\":null,\"DateTo\":null,\"Creater\":\"admin\",\"CreateTime\":\"2019-08-02T17:26:22\",\"StrCreateTime\":null,\"Modifyer\":null,\"ModifyTime\":null,\"Auditor\":null,\"AuditorTime\":null,\"RowVersion\":null,\"TerminateReasonID\":null,\"TerminateReason\":null,\"LineStatus\":null,\"DisplayID\":null,\"DisplayName\":null,\"InitFlag\":null,\"StrModifyTime\":null,\"TimeStamp\":null,\"StrVoucherType\":null,\"StrCreater\":null,\"VoucherType\":24,\"TaskNo\":null,\"StrLineStatus\":null,\"MaterialNoID\":2,\"MaterialDoc\":null,\"DocDate\":null,\"PostDate\":null,\"StrongHoldCode\":\"FY2\",\"StrongHoldName\":\"义乌菲扬\",\"CompanyCode\":\"10\",\"ERPCreater\":null,\"VouDate\":null,\"VouUser\":null,\"DepartmentCode\":null,\"DepartmentName\":null,\"ERPStatus\":null,\"ERPStatusCode\":null,\"ERPNote\":null,\"ErpLineStatus\":0,\"EDate\":\"0001-01-01T00:00:00\",\"StrEDate\":null,\"StockType\":0,\"ErpVoucherNo\":\"FY2-HH2-1907310001\",\"PrintIPAdress\":null,\"ERPVoucherType\":\"HH2\",\"StrModifyer\":null,\"OperUserNo\":null,\"MainTypeCode\":null},{\"lstSerialNo\":null,\"OutStockID\":0.0,\"MaterialNo\":\"10013417\",\"MaterialDesc\":\"21003玛丽佳人多用美目胶水-白胶12ml\",\"RowNo\":\"3\",\"Plant\":null,\"PlantName\":null,\"ToStorageLoc\":null,\"Unit\":\"PCS\",\"UnitName\":null,\"OutStockQty\":2.0,\"OldOutStockQty\":0.0,\"RemainQty\":0.0,\"Costcenter\":null,\"Wbselem\":null,\"FromStorageLoc\":null,\"ReviewStatus\":null,\"CloseOweUser\":null,\"CloseOweDate\":null,\"CloseOweRemark\":null,\"IsOweClose\":null,\"OweRemark\":null,\"OweRemarkUser\":null,\"OweRemarkDate\":null,\"OKSelect\":false,\"VoucherNo\":\"F201908023874\",\"BatchNo\":null,\"IsSerial\":0,\"PartNo\":null,\"RowNoDel\":\"1\",\"StockQty\":0.0,\"lstStock\":null,\"ScanQty\":0.0,\"CustomerCode\":null,\"CustomerName\":null,\"PalletNo\":null,\"FromBatchNo\":\"10002\",\"FromErpAreaNo\":\"1A0101\",\"FromErpWarehouse\":\"MS001\",\"ToBatchno\":\"\",\"ToErpAreaNo\":\"\",\"ToErpWarehouse\":\"\",\"PostUser\":null,\"SourceVoucherNo\":\"\",\"SourceRowNo\":\"\",\"IsSpcBatch\":\"N\",\"StrIsSpcBatch\":\"否\",\"SouStrongHoldCode\":null,\"ID\":11433,\"HeaderID\":9430,\"OrderNumber\":\"3\",\"Status\":0,\"EditText\":\"编辑\",\"StrStatus\":null,\"DateFrom\":null,\"DateTo\":null,\"Creater\":\"admin\",\"CreateTime\":\"2019-08-02T17:26:22\",\"StrCreateTime\":null,\"Modifyer\":null,\"ModifyTime\":null,\"Auditor\":null,\"AuditorTime\":null,\"RowVersion\":null,\"TerminateReasonID\":null,\"TerminateReason\":null,\"LineStatus\":null,\"DisplayID\":null,\"DisplayName\":null,\"InitFlag\":null,\"StrModifyTime\":null,\"TimeStamp\":null,\"StrVoucherType\":null,\"StrCreater\":null,\"VoucherType\":24,\"TaskNo\":null,\"StrLineStatus\":null,\"MaterialNoID\":2,\"MaterialDoc\":null,\"DocDate\":null,\"PostDate\":null,\"StrongHoldCode\":\"FY2\",\"StrongHoldName\":\"义乌菲扬\",\"CompanyCode\":\"10\",\"ERPCreater\":null,\"VouDate\":null,\"VouUser\":null,\"DepartmentCode\":null,\"DepartmentName\":null,\"ERPStatus\":null,\"ERPStatusCode\":null,\"ERPNote\":null,\"ErpLineStatus\":0,\"EDate\":\"0001-01-01T00:00:00\",\"StrEDate\":null,\"StockType\":0,\"ErpVoucherNo\":\"FY2-HH2-1907310001\",\"PrintIPAdress\":null,\"ERPVoucherType\":\"HH2\",\"StrModifyer\":null,\"OperUserNo\":null,\"MainTypeCode\":null},{\"lstSerialNo\":null,\"OutStockID\":0.0,\"MaterialNo\":\"10013418\",\"MaterialDesc\":\"21004玛丽佳人多用美目胶水-黑胶12ml\",\"RowNo\":\"4\",\"Plant\":null,\"PlantName\":null,\"ToStorageLoc\":null,\"Unit\":\"PCS\",\"UnitName\":null,\"OutStockQty\":50.0,\"OldOutStockQty\":0.0,\"RemainQty\":0.0,\"Costcenter\":null,\"Wbselem\":null,\"FromStorageLoc\":null,\"ReviewStatus\":null,\"CloseOweUser\":null,\"CloseOweDate\":null,\"CloseOweRemark\":null,\"IsOweClose\":null,\"OweRemark\":null,\"OweRemarkUser\":null,\"OweRemarkDate\":null,\"OKSelect\":false,\"VoucherNo\":\"F201908023874\",\"BatchNo\":null,\"IsSerial\":0,\"PartNo\":null,\"RowNoDel\":\"1\",\"StockQty\":0.0,\"lstStock\":null,\"ScanQty\":0.0,\"CustomerCode\":null,\"CustomerName\":null,\"PalletNo\":null,\"FromBatchNo\":\"201811300175\",\"FromErpAreaNo\":\"1A0301\",\"FromErpWarehouse\":\"MS001\",\"ToBatchno\":\"\",\"ToErpAreaNo\":\"\",\"ToErpWarehouse\":\"\",\"PostUser\":null,\"SourceVoucherNo\":\"\",\"SourceRowNo\":\"\",\"IsSpcBatch\":\"N\",\"StrIsSpcBatch\":\"否\",\"SouStrongHoldCode\":null,\"ID\":11434,\"HeaderID\":9430,\"OrderNumber\":\"4\",\"Status\":0,\"EditText\":\"编辑\",\"StrStatus\":null,\"DateFrom\":null,\"DateTo\":null,\"Creater\":\"admin\",\"CreateTime\":\"2019-08-02T17:26:22\",\"StrCreateTime\":null,\"Modifyer\":null,\"ModifyTime\":null,\"Auditor\":null,\"AuditorTime\":null,\"RowVersion\":null,\"TerminateReasonID\":null,\"TerminateReason\":null,\"LineStatus\":null,\"DisplayID\":null,\"DisplayName\":null,\"InitFlag\":null,\"StrModifyTime\":null,\"TimeStamp\":null,\"StrVoucherType\":null,\"StrCreater\":null,\"VoucherType\":24,\"TaskNo\":null,\"StrLineStatus\":null,\"MaterialNoID\":3,\"MaterialDoc\":null,\"DocDate\":null,\"PostDate\":null,\"StrongHoldCode\":\"FY2\",\"StrongHoldName\":\"义乌菲扬\",\"CompanyCode\":\"10\",\"ERPCreater\":null,\"VouDate\":null,\"VouUser\":null,\"DepartmentCode\":null,\"DepartmentName\":null,\"ERPStatus\":null,\"ERPStatusCode\":null,\"ERPNote\":null,\"ErpLineStatus\":0,\"EDate\":\"0001-01-01T00:00:00\",\"StrEDate\":null,\"StockType\":0,\"ErpVoucherNo\":\"FY2-HH2-1907310001\",\"PrintIPAdress\":null,\"ERPVoucherType\":\"HH2\",\"StrModifyer\":null,\"OperUserNo\":null,\"MainTypeCode\":null}]";
            EMSDLL.EMSDLL emsdll = new EMSDLL.EMSDLL();
            string strResult =  emsdll.PostOutStockToEms(strJson);
            MessageBox.Show(strResult);
        }
    }
}