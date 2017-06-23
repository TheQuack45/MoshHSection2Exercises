using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpIntermediateSection1
{
    public class Post
    {
        #region Members definition
        public string PostTitle { get; private set; }
        public string PostText { get; private set; }

        private readonly DateTime _dateCreated;
        public DateTime DateCreated
        {
            get { return _dateCreated; }
        }

        private int _postScore;
        public int PostScore
        {
            get { return _postScore; }
        }
        #endregion Members definition

        #region Constructors definition
        public Post(string title, string text, DateTime created)
        {
            if (String.IsNullOrEmpty(title))
            {
                throw new ArgumentException(nameof(title));
            }
            this.PostTitle = title;
            if (String.IsNullOrEmpty(text))
            {
                throw new ArgumentException(nameof(text));
            }
            this.PostText = text;
            this._dateCreated = created;
            this._postScore = 0;
        }
        #endregion Constructors definition

        #region Methods definition
        public void EditText(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                throw new ArgumentException(nameof(text));
            }

            this.PostText = text;
        }

        public void Upvote()
        {
            this._postScore++;
        }

        public void Downvote()
        {
            this._postScore--;
        }
        #endregion Methods definition
    }
}
