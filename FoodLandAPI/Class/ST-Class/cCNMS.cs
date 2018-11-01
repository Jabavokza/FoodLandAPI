using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodLandAPI.Class.ST_Class
{
    public static class cCNMS
    {

        #region Exception
        //public static string tMS_StatusCodeCreate = "001";
        //public static string tMS_StatusDescTHCreate = "ข้อมูล coupon เป็นค่า null.";
        //public static string tMS_StatusDescENCreate = "Data coupon is null.";

        //public static string tMS_ExStatusCode = "002";
        //public static string tMS_ExStatusDescTH = "เกิดข้อผิดพลาด";
        //public static string tMS_ExStatusDescEN = "";
        #endregion

        #region Craete
        public static string tMS_LogCreateSuccessful = "Add Data Successful";
        public static string tMS_LogCreateFalse = "หมายเลขคูปองซ้ำ";
        #endregion

        #region CouponSale
        public static string tMS_ValidStatusCodeSale = "0000";
        public static string tMS_ValidStatusDescTHSale = "คูปองสามารถใช้งานได้";
        public static string tMS_ValidStatusDescENSale = "Coupon is valid.";

        public static string tMS_ExpiredStatusCodeSale = "1001";
        public static string tMS_ExpiredStatusDescTHSale = "คูปองหมดอายุ";
        public static string tMS_ExpiredStatusDescENSale = "This coupon has been expired.";

        public static string tMS_UsedStatusCodeSale = "1002";
        public static string tMS_UsedStatusDescTHSale = "คูปองใช้ไปแล้ว";
        public static string tMS_UsedStatusDescENSale = "This coupon has been used.";

        public static string tMS_NotfoundStatusCodeSale = "1003";
        public static string tMS_NotfoundStatusDescTHSale = "ไม่พบคูปอง";
        public static string tMS_NotfoundStatusDescENSale = "Not found this coupon.";

        public static string tMS_VoidStatusCodeSale = "1004";
        public static string tMS_VoidStatusDescTHSale = "คูปองใช้ไม่ได้";
        public static string tMS_VoidStatusDescENSale = "Not found this coupon.";



        #endregion

        #region CouponRefun
        public static string tMS_NotfoundStatusCodeRefun = "1001";
        public static string tMS_NotfoundStatusDescTHRefun = "ไม่พบคูปองนี้";
        public static string tMS_NotfoundStatusDescENRefun = "Not found this coupon.";

        public static string tMS_SuccessStatusCodeRefun = "0000";
        public static string tMS_SuccessStatusDescTHRefun = "คืนสถานะคูปองสำเร็จ.";
        public static string tMS_SuccessStatusDescENRefun = "Return either success.";
        #endregion

        #region CouponVoid
        public static string tMS_NotfoundStatusCodeVoid = "1001";
        public static string tMS_NotfoundStatusDescTHVoid = "ไม่พบคูปองนี้";
        public static string tMS_NotfoundStatusDescENVoid = "Not found this coupon.";

        public static string tMS_SuccessStatusCodeVoid = "0000";
        public static string tMS_SuccessStatusDescTHVoid = "ยกเลิกคูปองสำเร็จ";
        public static string tMS_SuccessStatusDescENVoid = "Success.";
        #endregion

    }
}




