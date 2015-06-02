﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ReviewFilmsBus
    {
        private TURBO_PHIMEntities db = new TURBO_PHIMEntities();

        public bool addPost(BaiNhanXet baiNhanXet)
        {
            try
            {
                db.BaiNhanXet.Add(baiNhanXet);
                db.SaveChanges();

                return true;
            }

            catch (Exception e)
            {

                return false;
            }
        }


        public BaiNhanXet getTopReview(int IDPhim)
        {

            try
            {
                List<BaiNhanXet> lstReviews = db.BaiNhanXet.Where(x => x.MS_Phim == IDPhim).ToList();

                int flag = 0;

                int MS0 = lstReviews[0].MaSo;
                int temp = db.BinhChon.Where(y => y.MS_BaiNhanXet == MS0).ToList().Count;





                for (int i = 1; i < lstReviews.Count; i++)
                {
                    int MS = lstReviews[i].MaSo;
                    int tmp2 = db.BinhChon.Where(x => x.MS_BaiNhanXet == MS).ToList().Count;


                    if (tmp2 > temp)
                    {
                        temp = tmp2;
                        flag = i;
                    }


                }

                return lstReviews[flag];



            }

            catch (Exception e)
            {
                return null;

            }

        }

        public int getTotalRank(int? IDBaiNhanXet)
        {
            return db.BinhChon.Where(x => x.MS_BaiNhanXet == IDBaiNhanXet).Count();
        }

        public List<BaiNhanXet> getTop10Review(int IDPhim)
        {
            List<BaiNhanXet> result = new List<BaiNhanXet>();
            try
            {
                List<BaiNhanXet> lstReviews = db.BaiNhanXet.Where(x => x.MS_Phim == IDPhim).ToList();

                Dictionary<BaiNhanXet, int> Rank = new Dictionary<BaiNhanXet, int>();

                for (int i = 0; i < lstReviews.Count; i++)
                {

                    int MS = lstReviews[i].MaSo;
                    int tmp = db.BinhChon.Where(x => x.MS_BaiNhanXet == MS).ToList().Count;
                    Rank.Add(lstReviews[i], tmp);

                }


                foreach (KeyValuePair<BaiNhanXet, int> author in Rank.OrderByDescending(key => key.Value))
                {
                    result.Add(author.Key);
                }
               
                   
                
                return result;


            }

            catch (Exception e)
            {
                return null;

            }













        }

        public BaiNhanXet getReview(int p)
        {
            return db.BaiNhanXet.Where(x => x.MaSo == p).FirstOrDefault();
        }
    }
}