using System;
using System.Windows.Forms;
using BLL;
using DTO;

namespace SocialNetwork.Forms
{
    public partial class CommentForm : Form
    {
        string postId;
        string userIdCurrent;
        string commentId;

        public CommentForm(string postId, string commentId, string userIdCurrent)
        {
            InitializeComponent();
            this.postId = postId;
            this.userIdCurrent = userIdCurrent;
            this.commentId = commentId;
            Comment cm = PostBLL.GetCommentById(postId,commentId);
            labelCommentBody.Text = cm.CommentBody;
            labelCommentLikes.Text = "Likes: " + cm.Likes;
        }

        private void buttonLikeComment_Click(object sender, EventArgs e)
        {
            PostBLL.LikeComment(postId, commentId, userIdCurrent);

            labelCommentLikes.Text = "Likes: " + PostBLL.GetCommentById(postId,commentId).Likes;
        }
    }
}
