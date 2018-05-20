﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data_Acccess_Layer;
using Object;

namespace Bussiness_Logic_Layer
{
    public class TonKhoBUS
    {
        TonKhoDAO tonKhoDAO;
        public TonKhoBUS()
        {
            tonKhoDAO = new TonKhoDAO();
        }
        public DataTable getAllTonKho()
        {
            return tonKhoDAO.GetAllTonKho();          
        }
        public DataTable GetAllTonKhoByMaKhoBUS(TonKhoO tk)
        {
            return tonKhoDAO.GetAllTonKhoByMaKho(tk);
        }
        public bool ThemTonKhoBUS(ref string err, TonKhoO tk)
        {
            return tonKhoDAO.XuatTonKho(ref err, tk);
        }
        public bool XuatTonKhoBUS(ref string err, TonKhoO tk)
        {
            return tonKhoDAO.XuatTonKho(ref err, tk);
        }
        public bool CapNhatTonKhoBUS(ref string err, TonKhoO tk)
        {
            return tonKhoDAO.CapNhatTonKho(ref err, tk);
        }
        public bool XoaTonKhoBUS(ref string err, TonKhoO tk)
        {
            return tonKhoDAO.XoaTonKho(ref err, tk);
        }
    }
}
