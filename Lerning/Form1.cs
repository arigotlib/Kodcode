using System;
using System.Windows.Forms;

namespace Lernung
{
    public partial class Form1 : Form
    {
        Dog[] dogs = new Dog[20];
        public Form1()
        {
            InitializeComponent();
        }

        
        private void startDogs_Click(object sender, EventArgs e)
        {
            // 1.
            Dog dog1 = new Dog();
            dog1.Height = 95.2f;
            dog1.Weight = 62.3f;
            dog1.Name = "Jhoni";
            dog1.Food = "Beef";
            dog1.Size();
           
            dog1.Eat();
            dog1.Plye();

            // 2.
            Dog dog2 = new Dog(50,23.8f, "Guri", "Bones");
            dog2.Size();
            
            dog2.Eat();
            dog2.Plye();
        }

        private void btnStartRuning_Click(object sender, EventArgs e)
        {
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            dog1.Run();
            dog2.Run();
        }

        private void btnStartEating_Click(object sender, EventArgs e)
        {
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            dog1.Eat();
            dog2.Eat();
        }

        private void btnStartPlaying_Click(object sender, EventArgs e)
        {
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            dog1.Plye();
            dog2.Plye();
        }
    }
}
