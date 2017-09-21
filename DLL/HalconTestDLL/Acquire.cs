//
//  File generated by HDevelop for HALCON/DOTNET (C#) Version 10.0
//

using HalconDotNet;

public partial class HDevelopExport
{

	public static HTuple mWindow;
	// Main procedure 
	public static void acquireimage()
	{
		HTuple hv_Heigh;
		HTuple hv_Width;

		// Local iconic variables 
		HObject ho_Image = null;

		// Local control variables 
		HTuple hv_AcqHandle, hv_WindowHandle;

		// Initialize local and output iconic variables 
		HOperatorSet.GenEmptyObj(out ho_Image);

        //Code generated by Image Acquisition 01
        HOperatorSet.OpenFramegrabber("DirectShow", 1, 1, 0, 0, 0, 0, "default", 8, "rgb",
            -1, "false", "default", "[0] Intel(R) RealSense(TM) 3D Camera Virtual Driver",
            0, -1, out hv_AcqHandle);
        HOperatorSet.GrabImageStart(hv_AcqHandle, -1);
		HOperatorSet.SetWindowAttr("background_color", "black");
		//HOperatorSet.OpenWindow(0,0,512,512,0,"","",out hv_WindowHandle);
		// HDevWindowStack.Push(hv_WindowHandle);
		while ((int)(1) != 0)
		{
			ho_Image.Dispose();
			HOperatorSet.GrabImageAsync(out ho_Image, hv_AcqHandle, -1);
			HOperatorSet.GetImageSize(ho_Image, out hv_Width, out hv_Heigh);
			HOperatorSet.SetPart(mWindow, 0, 0, hv_Heigh, hv_Width);
			HOperatorSet.DispObj(ho_Image, mWindow);
			//Do something
		}
	}
}
