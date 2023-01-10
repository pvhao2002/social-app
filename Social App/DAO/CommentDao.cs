using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Social_App.DTO;
using Social_App.BUS;
using System.Data;

namespace Social_App.DAO
{
    public class CommentDao
    {
        private static CommentDao instance;
        public static CommentDao Instance
        {
            get
            {
                if (instance == null)
                    instance = new CommentDao();
                return instance;
            }
        }
        private CommentDao()
        {

        }


        public List<Comment> findAllById(int id)
        {
            List<Comment> list = new List<Comment>();
            string sql = "SELECT * FROM comments WHERE comment_id = " + id.ToString();
            DataTable data = DBConnect.Instance.ExecuteQuery_DataTable(sql);
            foreach (DataRow item in data.Rows)
            {
                int comment_id = (int)item["comment_id"];
                int post_id = (int)item["post_id"];
                int user_id = (int)item["user_id"];
                string content = item["content"].ToString();
                DateTime comment_time = DateTime.Parse(item["comment_time"].ToString());
                Comment cmt = new Comment(comment_id, post_id, user_id, content, comment_time);
                list.Add(cmt);
            }
            return list;
        }
        public List<Comment> findAllCommentInPost(int postid)
        {
            List<Comment> list = new List<Comment>();
            string sql = "SELECT * FROM comments WHERE post_id = " + postid.ToString();
            DataTable data = DBConnect.Instance.ExecuteQuery_DataTable(sql);
            foreach (DataRow item in data.Rows)
            {
                int comment_id = (int)item["comment_id"];
                int post_id = (int)item["post_id"];
                int user_id = (int)item["user_id"];
                string content = item["content"].ToString();
                DateTime comment_time = DateTime.Parse(item["comment_time"].ToString());
                Comment cmt = new Comment(comment_id, post_id, user_id, content, comment_time);
                list.Add(cmt);
            }
            return list;
        }
    }
}
