using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangAccess dal = new KhachHangAccess();   
        public List<KhachHang> GetAllKhachHang()
        {
            return dal.GetAllKhachHang();
        }
        public bool AddKhachHang(KhachHang kh, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(kh.ID_Khach) || string.IsNullOrWhiteSpace(kh.Name_customer) || string.IsNullOrWhiteSpace(kh.Phone_customer))
            {
                error = "Không được để trống thông tin khách hàng!";
                return false;
            }
            else if (kh.Name_customer.Length > 50)
            {
                error = "Tên khách hàng không được quá 50 ký tự!";
                return false;
            }
            else if (dal.CheckID(kh.ID_Khach))
            {
                error = "ID khách hàng đã tồn tại!";
                return false;
            }
            else if (dal.CheckPhone(kh.Phone_customer))
            {
                error = "Số điện thoại đã tồn tại!";
                return false;
            }
            return dal.AddKhachHang(kh);
        }
        public bool UpdateKhachHang(KhachHang kh, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(kh.ID_Khach))
            {
                error = "ID cannot be empty.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(kh.Name_customer))
            {
                error = "Tên KH không được để trống!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(kh.Phone_customer))
            {
                error = "Số điện thoại không được để trống!";
                return false;
            }
            return dal.UpdateKhachHang(kh);
        }
        public bool DeleteKhachHang(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return false;
            }
            return dal.DeleteKhachHang(id);
        }
        public List<KhachHang> SearchKhachHang(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetAllKhachHang();
            return dal.SearchKhachHang(keyword);
        }
    }
}
