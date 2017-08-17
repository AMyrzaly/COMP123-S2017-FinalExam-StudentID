using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Abubakir Myrzaly
 * Date: 8/17/2017
 * StudentID: 300931945
 * Description: ScoreBoard class
 * Version: 0.1 Just create class
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    class ScoreBoard
    {
        // PRIVATE FIELDS (INSTANCE VARIABLES)

        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;

        // PUBLIC PROPERTIES

        public TextBox FinalScoreTextBox {
            get
            {
                return _finalScoreTextBox;
            }
            set
            {
                _finalScoreTextBox = value;
            }
        }
        public int Score {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
                ScoreTextBox.Text = Convert.ToString(Score);
                FinalScoreTextBox.Text = Convert.ToString(this._score);
            }
        }
        public TextBox ScoreTextBox {
            get
            {
                return _scoreTextBox;
            }
            set
            {
                _scoreTextBox = value;
            }
        }
        public int Time {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
                TimeTextBox.Text = Convert.ToString(_time);
            }
        }
        public TextBox TimeTextBox {
            get
            {
                return _timeTextBox;
            }
            set
            {
                _timeTextBox = value;
            }
        }

        // CONSTRUCTORS

        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            this.ScoreTextBox = scoreTextBox;
            this.TimeTextBox = timeTextBox;
            this.FinalScoreTextBox = finalScoreTextBox;
        }

        // PUBLIC METHODS

        public void UpdateTime()
        {
            Time = Convert.ToInt32(Time);
            Time -= 1;
            TimeTextBox.Text = Convert.ToString(Time);
        }
    }
}
