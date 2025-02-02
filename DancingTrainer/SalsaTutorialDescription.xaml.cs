﻿using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace DancingTrainer
{
    /// <summary>
    /// Interaction logic for SalsaTutorialDescription.xaml
    /// </summary>
    public partial class SalsaTutorialDescription : Window
    {
        /// <summary>
        /// Index of the content.
        /// </summary>
        int tutorialIndex = 0;

        /// <summary>
        /// Maximum number of contents.
        /// </summary>
        int maxIdx = 4;

        /// <summary>
        /// Minimum number of contents.
        /// </summary>
        int minIdx = 0;

        /// <summary>
        /// Constructor.
        /// </summary>
        public SalsaTutorialDescription()
        {
            InitializeComponent();
            ShowContent();
        }

        /// <summary>
        /// Shows the content.
        /// </summary>
        private void ShowContent()
        {
            switch (tutorialIndex)
            {
                case 0:
                    textbox_Description.Text = "The left foot is highlighted with green and the right foot with red. " +
                        "Darker color indicates the foot that has to be moved. " +
                        "Lighter color indicates a grounded foot. ";
                    img_Description.Source = new BitmapImage(new Uri(@"images\salsaSteppingOrderComplete.png", UriKind.RelativeOrAbsolute));
                    break;
                case 1:
                    textbox_Description.Text = "Salsa Forward Movements \n" +
                        "On 8 you start and end in a grounded position with shoulderwide placed feet. " +
                        "On 1 take a step forward with your left foot and hold the position. " +
                        "On 2 tap with your right foot. " +
                        "On 3 return to your starting position. " +
                        "On 4 pause. " +
                        "On 5 take a step back with your right foot and hold the position. " +
                        "On 6 tap with your left foot. " +
                        "On 7 return to your starting position.\n";
                    img_Description.Source = new BitmapImage(new Uri(@"images\salsaSteppingOrderComplete.png", UriKind.RelativeOrAbsolute));
                    break;
                case 2:
                    textbox_Description.Text = "Salsa Sideways Movement \n" +
                        "On 8 you start and end in a grounded position with shoulderwide placed feet. " +
                        "On 1 take a step to your left side with your left foot and hold the position. " +
                        "On 2 tap with your right foot. " +
                        "On 3 return to your starting position. " +
                        "On 4 pause. " +
                        "On 5 take a step to your right side with your right foot and hold the position. " +
                        "On 6 tap with your left foot. " +
                        "On 7 return to your starting position.";
                    img_Description.Source = new BitmapImage(new Uri(@"images\salsaSteppingSideOrderComplete.png", UriKind.RelativeOrAbsolute));
                    break;
                case 3:
                    textbox_Description.Text = "During a normal dancing session feedback is shown in the blue box between the feet. " +
                        "For a tutorial it can be ignored. " +
                        "Every feedback is supported by a little instruction. "+
                        "Counting the beat in Salsa is not an easy task as there are different instruments playing at different beats. " +
                        "That is why a beat counter supports you in normal dancing session.";
                    img_Description.Source = new BitmapImage(new Uri(@"images\beatCounterFeedbackSpot.png", UriKind.RelativeOrAbsolute));
                    break;
                case 4:
                    textbox_Description.Text = "Here are all the feedbacks and their instructions. From Left to Right:\n" +
                        "Activates when you are not dancing to the beat.\n" +
                        "Activates when you do not look straight. Having a straight spine prevents back problems.\n" +
                        "Activates when you do not involve your upper body when dancing. You do not want to dance the robot. \n" +
                        "Activates when you are not smiling. Smiling transmits positive emotions.";
                    img_Description.Source = new BitmapImage(new Uri(@"images\feedback.png", UriKind.RelativeOrAbsolute));
                    break;
            }
        }

        /// <summary>
        /// Event to go to previous content.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">RoutedEventArgs</param>
        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            tutorialIndex--;
            if (tutorialIndex == maxIdx-1)
            {
                button_Next.IsEnabled = true;
            }
            if (tutorialIndex == minIdx)
            {
                button_Back.IsEnabled = false;
            }
            ShowContent();
        }

        /// <summary>
        /// Event to go to next content.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">RoutedEventArgs</param>
        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            tutorialIndex++;
            if (tutorialIndex == maxIdx)
            {
                button_Next.IsEnabled = false;
            }
            if (tutorialIndex == minIdx+1)
            {
                button_Back.IsEnabled = true;
            }
            ShowContent();
        }

        /// <summary>
        /// Event to close the window.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">RoutedEventArgs</param>
        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
