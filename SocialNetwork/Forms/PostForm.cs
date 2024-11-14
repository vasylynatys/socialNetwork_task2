using System;
using System.Windows.Forms;
using SocialNetwork.Forms;
using BLL;
using DTO;

namespace SocialNetwork
{
    public partial class PostF : Form
    {
        string postId;
        string userIdCurrent;

        public PostF(string postId, string userIdCurrent)
        {
            this.postId = postId;
            this.userIdCurrent = userIdCurrent;
            InitializeComponent();
        }

        private void PostF_Load(object sender, EventArgs e)
        {
            Post p = PostBLL.GetPostById(postId);
            labelTitle.Text = p.Title;
            labelBodyPost.Text = p.Body;
            labelLikes.Text = "Likes: " + p.LikesPost.ToString();
        }

        private void buttonLikes_Click(object sender, EventArgs e)
        {
            PostBLL.LikePost(postId, userIdCurrent);

            labelLikes.Text = "Likes: " + PostBLL.GetPostById(postId).LikesPost.ToString();
        }

        private void buttonComments_Click(object sender, EventArgs e)
        {
            using (Comments cm = new Comments(postId, userIdCurrent))
            {
                cm.ShowDialog();
            }
        }

    }
}
