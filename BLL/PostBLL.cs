using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class PostBLL
    {
        public static List<Post> GetSortedPosts()
        {
            return PostDAL.GetSortedPosts();
        }

        public static Post GetPostById(string postId)
        {
            return PostDAL.GetPostById(postId);
        }

        public static Comment GetCommentById(string postId, string commentId)
        {
            return PostDAL.GetCommentById(postId,commentId);
        }

        public static List<Post> GetUserPosts(string userId)
        {
            return PostDAL.GetUserPosts(userId);
        }

        public static string AddComment(string postId, Comment comment)
        {
            return PostDAL.AddComment(postId,comment).Id;
        }

        public static string AddPost(Post post)
        {
            return PostDAL.AddPost(post).Id;
        }

        public static void LikePost(string postId, string userIdCurrent)
        {
            PostDAL.LikePost(postId,userIdCurrent);
        }

        public static void LikeComment(string postId, string commentId, string userIdCurrent)
        {
            PostDAL.LikeComment(commentId, userIdCurrent);
        }
    }
}
