﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Turbo_Phim.Services;

namespace Turbo_Phim.Models
{
    public class TopReviewModels
    {
      
        public String content { get; set; }


        public String UserName { get; set; }

        public int totalRank { get; set; }

        public String title { get; set; }
      

        public DateTime postDate { get; set; }


        public int MS_Phim { get; set; }

        public int MS_ReView { get; set; }

        public String TenPhim { get; set; }

        public bool isVoted(string user_name, int ms_review)
        {
            LikeReviewPostService sv = new LikeReviewPostService();
            return sv.isVoted(user_name, ms_review);
        }



        public String ulr_HinhAnh { get; set; }


        public string MS_TaiKhoan;


        
    }
}