using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class table_clear
{
    string[] tables = new string[]  {  
          "tbl_Admin","tbl_channel","tbl_comment","tbl_like",
          "tbl_playlist","tbl_subscibe","tbl_video","tbl_Youtuber","tbl_category"
    };
    public table_clear()
    {
        for (int i = 0; i < tables.Length; i++)
               helper.crud("DELETE FROM " + tables[i].ToString() + " WHERE is_act=1");
    }
}