using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class GameProcessor
    {
        public static List<ArcadeList> LoadByTitle()
            {
                string sql = @"dbo.full_list;";

                return SQLDataAccess.LoadData<ArcadeList>(sql);
            }
        public static List<ArcadeList> LoadByRelease()
        {
            string sql = @"dbo.GameByDate;";

            return SQLDataAccess.LoadData<ArcadeList>(sql);
        }
        public static List<ArcadeList> LoadByHardware()
        {
            string sql = @"dbo.GameByHardware;";

            return SQLDataAccess.LoadData<ArcadeList>(sql);
        }
        public static List<ArcadeList> LoadByGenre()
        {
            string sql = @"dbo.GameByGenre;";

            return SQLDataAccess.LoadData<ArcadeList>(sql);
        }
    }
}
