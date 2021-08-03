using BigAds.Models;
using BigAds.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigAds.Data
{
    public class CauHoi
    {
        CAUHOI cauhoi_dal = new CAUHOI();
        public DataTable load_cauhoi(CAUHOI cauhoi_public)
        {
            return cauhoi_dal.load_cauhoi(cauhoi_public);
        }
        public int insert_iddethi(CAUHOI cauhoi_public)
        {
            return cauhoi_dal.insert_iddethi(cauhoi_public);
        }
        public int insert_cauhoi(CAUHOI cauhoi_public)
        {
            return cauhoi_dal.insert_cauhoi(cauhoi_public);
        }
        public int update_cauhoi(CAUHOI cauhoi_public)
        {
            return cauhoi_dal.update_cauhoi(cauhoi_public);
        }
        public int delete_cauhoi(CAUHOI cauhoi_public)
        {
            return cauhoi_dal.delete_cauhoi(cauhoi_public);
        }
        public int update_cauhoidachon(CAUHOI cauhoi_public)
        {
            return cauhoi_dal.update_cauhoidachon(cauhoi_public);
        }
        public int update_cauhoidachonRD(CAUHOI cauhoi_public)
        {
            return cauhoi_dal.update_cauhoidachonRD(cauhoi_public);
        }
        public DataTable load_cauhoidachon(CAUHOI cauhoi_public)
        {
            return cauhoi_dal.load_cauhoidachon(cauhoi_public);
        }
        public int check_caudung(CAUHOI cauhoi_public)
        {
            return cauhoi_dal.check_caudung(cauhoi_public);
        }
        public DataTable load_cauhoi_insert(CAUHOI cauhoi_public)
        {
            return cauhoi_dal.load_cauhoi_insert(cauhoi_public);
        }
        public int delete_cauhoiDACHON(CAUHOI cauhoi_public)
        {
            return cauhoi_dal.delete_cauhoiDACHON(cauhoi_public);
        }
    }
}
