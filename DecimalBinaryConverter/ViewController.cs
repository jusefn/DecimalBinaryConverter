using System;

using AppKit;
using Foundation;

namespace DecimalBinaryConverter
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        /// <summary>
        /// Button that converts input string to binary.
        /// </summary>
        /// <param name="sender"></param>
        partial void convertButton(Foundation.NSObject sender)
        {
            int input = Convert.ToInt32(inputLabel.StringValue);
            string output = ConvClass.Binary(input);
            outputLabel.StringValue = output;
        }
    }
}
