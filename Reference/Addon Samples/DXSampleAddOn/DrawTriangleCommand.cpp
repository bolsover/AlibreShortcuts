// DrawTriangleCommand.cpp: implementation of the CDrawTriangleCommand class.
//
//////////////////////////////////////////////////////////////////////

#include "stdafx.h"
#include "ADSampleAddOnDX.h"
#include "DrawTriangleCommand.h"
#include <string>
#include "AddOnSupport.h"

extern CADSampleAddOnDXApp theApp;

#ifdef _DEBUG
#undef THIS_FILE
static char THIS_FILE[]=__FILE__;
#define new DEBUG_NEW
#endif

int	m_nGlobalDrawCounter;

EXTERN_C IMAGE_DOS_HEADER __ImageBase;


bool DrawScreenText(IADAddOnCanvasDisplay* pCanvasDisplay, IADAddOnCommandSite* pCmdSite, HWND browserHWND, LONG64 textSegment)
{
	int pLeftTop[2];
	int pLeftBottom[2];
	int pRightTop[2];
	int pRightBottom[2];

	if (browserHWND)
	{
		RECT rect;
		if (GetWindowRect(browserHWND, &rect))
		{
			pLeftTop[0] = rect.left - rect.left;
			pLeftTop[1] = rect.top - rect.top;

			pRightBottom[0] = rect.right - rect.left;
			pRightBottom[1] = rect.bottom - rect.top;

			pLeftBottom[0] = rect.left - rect.left;
			pLeftBottom[1] = rect.bottom - rect.top;

			pRightTop[0] = rect.right - rect.left;
			pRightTop[1] = rect.top - rect.top;
		}
		else
		{
			printf("Failed to get window rect.\n");
			return false;
		}
	}
	else
	{
		printf("Bad window handle.\n");
		return false;
	}

	// Print the points.
	printf("LeftTop = %d, %d\n", pLeftTop[0], pLeftTop[1]);
	printf("LeftBottom = %d, %d\n", pLeftBottom[0], pLeftBottom[1]);
	printf("RightTop = %d, %d\n", pRightTop[0], pRightTop[1]);
	printf("RightBottom = %d, %d\n", pRightBottom[0], pRightBottom[1]);

	// Draw the text.
	BSTR fontName = SysAllocString(L"Arial");
	BSTR leftTopText = SysAllocString(L"LeftTop");
	BSTR leftBottomText = SysAllocString(L"LeftBottom");
	BSTR rightTopText = SysAllocString(L"RightTop");
	BSTR rightBottomText = SysAllocString(L"RightBottom");
	LONG64 resultMesh;

	pCanvasDisplay->DrawScreenText(textSegment, leftTopText, pLeftTop[0], pLeftTop[1], TextAlignment::TextAlignment_TopLeft, fontName, 16.0F, 0xFFFF0000 /*red*/, true, &resultMesh);
	pCanvasDisplay->DrawScreenText(textSegment, leftBottomText, pLeftBottom[0], pLeftBottom[1], TextAlignment::TextAlignment_BottomLeft, fontName, 16.0F, 0xFFFF0000 /*red*/, true, &resultMesh);
	pCanvasDisplay->DrawScreenText(textSegment, rightTopText, pRightTop[0], pRightTop[1], TextAlignment::TextAlignment_TopRight, fontName, 16.0F, 0xFFFF0000 /*red*/, true, &resultMesh);
	pCanvasDisplay->DrawScreenText(textSegment, rightBottomText, pRightBottom[0], pRightBottom[1], TextAlignment::TextAlignment_BottomRight, fontName, 16.0F, 0xFFFF0000 /*red*/, true, &resultMesh);

	SysFreeString(fontName);
	SysFreeString(leftTopText);
	SysFreeString(leftBottomText);
	SysFreeString(rightTopText);
	SysFreeString(rightBottomText);

	return true;
}


// Internal method to draw triangle using the Alibre supplied IADAddOnCanvasDisplay interface.
// This will use Hoops Visualize rendering engine that Alibre Design's rendering platform is built on.
bool DrawTriangle (IADAddOnCanvasDisplay* pCanvasDisplay, LPWSTR pImageFilePath, IADAddOnCommandSite* pCmdSite)
{
	float vertices[] = { -5.0f, 0.0f, 0.0f,  5.0f, 0.0f, 0.0f,  0.0f, 5.0f, 0.0f };
	float normals[] = { 0.0f, 0.0f, 1.0f,  0.0f, 0.0f, 1.0f,  0.0f, 0.0f, 1.0f };
	int indices[] = { 3, 0, 1, 2 };

	float vertexUVs[] = { 0.0f,0.0f,   1.0f,1.0f,   0.5f,1.0f };

	float fltOffset = m_nGlobalDrawCounter * 5.0f;	 // Offset Triangle everytime
	D3DXMATRIX WM = D3DXMatrixTranslation (fltOffset, 0.0f, 0.0f);

	double transform[] = { WM.m[0][0], WM.m[0][1], WM.m[0][2],
		WM.m[1][0], WM.m[1][1], WM.m[1][2],
		WM.m[2][0], WM.m[2][1], WM.m[2][2],
		WM.m[3][0], WM.m[3][1], WM.m[3][2] };

	SAFEARRAY *saVertices = NULL;
	SAFEARRAY *saNormals = NULL;
	SAFEARRAY *saIndices = NULL;
	SAFEARRAY *saTransform = NULL;
	SAFEARRAY *saVertexUVparams = NULL;

	if (getSafeArrayFromArray<float>(vertices, (long)9, VT_R4, &saVertices) != S_OK)
		return false;
	if (getSafeArrayFromArray<float>(normals, (long)9, VT_R4, &saNormals) != S_OK)
		return false;
	if (getSafeArrayFromArray<int>(indices, (long)4, VT_I4, &saIndices) != S_OK)
		return false;
	if (getSafeArrayFromArray<double>(transform, (long)12, VT_R8, &saTransform) != S_OK)
		return false;

	LONG64 result;
	LONG64 mySegment;
	BSTR mySegmentName = SysAllocString (L"My Triangle");
	pCanvasDisplay->AddSubSegment (NULL, mySegmentName, &mySegment);
	pCanvasDisplay->SetSegmentTransform (mySegment, VARIANT_TRUE, &saTransform);
	pCanvasDisplay->SetSegmentColor (mySegment, 255, 255, 0, 255);	// yellow
	SysFreeString(mySegmentName);

	/////////
	// NOTE: TO DISPLAY COLORED MESH UNCOMMENT THE FOLLOWING LINE (CALL TO "DrawMesh") AND COMMENT OUT THE CODE BLOCK BELOW IT THAT DRAWS TEXTURED MESH
	/////////
	/*
	pCanvasDisplay->DrawMesh (mySegment, &saVertices, &saNormals, &saIndices, &result);
	*/

	/////////
	// NOTE: TO DISPLAY TEXTURED MESH UNCOMMENT THE CODE BLOCK BELOW AFTER COMMENTING THE CALL TO "DrawMesh" (ABOVE)
	////////
	// START TEXTURE BLOCK
	if (getSafeArrayFromArray<float>(vertexUVs, (long)6, VT_R4, &saVertexUVparams) != S_OK)
		return false;
	BSTR textureName = SysAllocString (L"Wood");
	BSTR imagePath = SysAllocString (pImageFilePath);
	pCanvasDisplay->DefineTexture (mySegment, textureName, ImageFormat_JPEG, imagePath);
	pCanvasDisplay->SetFaceTexture (mySegment, textureName);

	pCanvasDisplay->DrawTexturedMesh (mySegment, &saVertices, &saNormals, &saVertexUVparams, &saIndices, &result);

	SafeArrayDestroy (saVertexUVparams);
	SysFreeString (textureName);
	SysFreeString (imagePath);
	// END TEXTURE BLOCK

	// Draw a polyline that spans two sides of the triangle
	pCanvasDisplay->DrawPolyline(mySegment, &saVertices, &result);

	// Set line weight
	pCanvasDisplay->SetLineWeight(mySegment, 2.0f);

	// Toggle foreground rendering OFF. Pass 'true' if you want the contents of 'mysegment' to ignore depth buffer and always display as an overlay
	pCanvasDisplay->ToggleForegroundRendering(mySegment, false);

	// Draw a rectangular marker at the three vertices of the triangle
	long diagnol = 25;
	pCanvasDisplay->DrawMarker(mySegment, vertices[0], vertices[1], vertices[2], diagnol, MarkerType::MarkerType_MARKER_RECT);
	pCanvasDisplay->DrawMarker(mySegment, vertices[3], vertices[4], vertices[5], diagnol, MarkerType::MarkerType_MARKER_RECT);
	pCanvasDisplay->DrawMarker(mySegment, vertices[6], vertices[7], vertices[8], diagnol, MarkerType::MarkerType_MARKER_RECT);

	// Draw a text string at the third triangle vertex
	BSTR text = SysAllocString(L"My Triangle");
	BSTR fontName = SysAllocString(L"Arial");
	pCanvasDisplay->DrawTextMesh(mySegment, text, vertices[6], vertices[7], vertices[8], TextAlignment::TextAlignment_CenterLeft, 
								 fontName, 16.0F, 0xFFFF0000 /*red*/, VARIANT_FALSE, VARIANT_FALSE, VARIANT_FALSE, &result);
	SysFreeString(text);
	SysFreeString(fontName);

	SafeArrayDestroy (saVertices);
	SafeArrayDestroy (saNormals);
	SafeArrayDestroy (saIndices);
	SafeArrayDestroy (saTransform);
	
	return true;
}


CDrawTriangleCommand::CDrawTriangleCommand() 
{
	m_nRefCount = 0;
	m_pCmdSite = NULL;
	m_bClearViewPort = VARIANT_FALSE;
	m_bOverrideRender = VARIANT_FALSE;
	m_bIsOutOfDate = true;

}


CDrawTriangleCommand::CDrawTriangleCommand(VARIANT_BOOL bOverrideRender, VARIANT_BOOL bClearViewPort) 
{
	m_nRefCount = 0;
	m_pCmdSite = NULL;
	m_bClearViewPort = bClearViewPort;
	m_bOverrideRender = bOverrideRender;
	m_nGlobalDrawCounter = 0;
	m_bIsOutOfDate = true;

	LPWSTR  strDLLPath = new WCHAR[_MAX_PATH];
	::GetModuleFileNameW((HINSTANCE)&__ImageBase, strDLLPath, _MAX_PATH);
	::PathRemoveFileSpecW (strDLLPath);
	::PathCombineW (m_imageFilePath, strDLLPath, L"wood.jpg");
}


CDrawTriangleCommand::~CDrawTriangleCommand()
{

}


// IAlibreAddOnCommand interface methods implementation

//
// Indicates whether to add Tab to AD Design Explorer UI.
//

HRESULT _stdcall CDrawTriangleCommand::AddTab (VARIANT_BOOL *pAddTab)
{	
	// Return FALSE as we this command does not add a tab to Alibre's Exporer pane
	*pAddTab = VARIANT_FALSE;
	return S_OK;
}


//
// Gets TabName. This is called only if AddTab () returned TRUE
//

HRESULT _stdcall CDrawTriangleCommand::get_TabName(/*[out], [retval]*/ BSTR* pTabName)
{
	// This addon command sample provides no implementation
	HRESULT hr = S_OK;
	pTabName = NULL;
	return hr;
}


//
// Returns IADAddOnCommandSite object of this command when Alibre queries it
//

HRESULT _stdcall CDrawTriangleCommand::get_CommandSite(/* [retval][out] */ IADAddOnCommandSite **pSite)
{
	if (m_pCmdSite)
	{
		m_pCmdSite->QueryInterface (pSite);
	}

	return S_OK;
}


//
// Indicates if it is a TwoWay Toggle command 
//

HRESULT _stdcall CDrawTriangleCommand::IsTwoWayToggle( /* [retval][out] */ VARIANT_BOOL *pIsTwoWayToggle)
{
	// Return FALSE to indicate this is not a two way toggle command
	*pIsTwoWayToggle = VARIANT_FALSE;	
	return S_OK;
}


//
// Handles OnClick event. Use it if you want to do any special processing.
//

HRESULT _stdcall CDrawTriangleCommand::OnClick (long screenX, long screenY, enum ADDONMouseButtons buttons, VARIANT_BOOL *pIsHandled)
{
	// This addon command sample provides no implementation
	*pIsHandled = VARIANT_FALSE;
	return S_OK;
}


//
// Called after the addon command is launched. Do any command specific initializations here
//

HRESULT _stdcall CDrawTriangleCommand::OnComplete( void)
{
	// Call back into the command site to set the display behavior of this addon command
	if (m_bOverrideRender)
		m_pCmdSite->Override3DRender(VARIANT_TRUE);	//TRUE means addon command wants to suppress the normal display by Alibre and wants to take full control of canvas

	// we invalidate canvas to display triangle
	m_bIsOutOfDate = true;
	m_pCmdSite->InvalidateCanvas ();

	return S_OK;
}


//
// Handles OnMouseDown () event. Use it to override the default event handler from AD.
//

HRESULT _stdcall CDrawTriangleCommand::OnMouseDown (long screenX, long screenY, enum ADDONMouseButtons buttons, VARIANT_BOOL *pIsHandled)
{
	// This addon command sample provides no implementation
	*pIsHandled = VARIANT_FALSE;
	return S_OK;
}


//
// Handles OnMouseMove () event. Use it to override the default event handler from AD.
//

HRESULT _stdcall CDrawTriangleCommand::OnMouseMove (long screenX, long screenY, enum ADDONMouseButtons buttons, VARIANT_BOOL *pIsHandled)
{
	// This addon command sample provides no implementation
	*pIsHandled = VARIANT_FALSE;
	return S_OK;
}


//
// Handles OnMouseUp () event. Use it to override the default event handler from AD.
//
    
HRESULT _stdcall CDrawTriangleCommand::OnMouseUp (long screenX, long screenY, enum ADDONMouseButtons buttons, VARIANT_BOOL *pIsHandled)
{
	// This addon command sample provides no implementation
	*pIsHandled = VARIANT_FALSE;
 	return S_OK;
 
}


//
// Handles OnMouseWheel () event. Use it to override the default event handler from AD.
//

HRESULT _stdcall CDrawTriangleCommand::OnMouseWheel (double delta, VARIANT_BOOL *pIsHandled)
{
	// This addon command sample provides no implementation
	*pIsHandled = VARIANT_FALSE;
	return S_OK;
}
    

//
// Handles OnKeyDown () event. Use it to override the default event handler from AD
//

HRESULT _stdcall CDrawTriangleCommand::OnKeyDown (long keyCode, VARIANT_BOOL *pIsHandled)
{
	// bump up the offset counter to offset the triangle with each key stroke
	m_nGlobalDrawCounter++;
	m_bIsOutOfDate = true;
	// update canvas to display triangle
	m_pCmdSite->UpdateCanvas ();
	*pIsHandled = VARIANT_TRUE;

	return S_OK;
}


//
// Handles OnKeyUp () event. Use it to override the default event handler from AD
//

HRESULT _stdcall CDrawTriangleCommand::OnKeyUp (long keyCode, VARIANT_BOOL *pIsHandled)
{
	// This addon command sample provides no implementation
	*pIsHandled = VARIANT_FALSE;
	return S_OK;
}


//
// Handles OnEscape () event
//

HRESULT _stdcall CDrawTriangleCommand::OnEscape (VARIANT_BOOL *pIsHandled)
{
	// Make sure Alibre's standard display is restored when the command is terminated
	m_pCmdSite->Override3DRender(VARIANT_FALSE);

	// InvalidateCanvas and Terminate this command
	m_bIsOutOfDate = true;
	m_pCmdSite->InvalidateCanvas ();
	m_pCmdSite->Terminate ();

	*pIsHandled = VARIANT_TRUE;
	return S_OK;
}

//
// Handles DoubleClick event. Use it for any special processing.
//

HRESULT _stdcall CDrawTriangleCommand::OnDoubleClick (long screenX, long screenY, VARIANT_BOOL *pIsHandled)
{
	// We do the same as what we did when user pressed the Escape key (see OnEscape above)
	m_pCmdSite->Override3DRender(VARIANT_FALSE);
	m_bIsOutOfDate = true;
	m_pCmdSite->InvalidateCanvas ();
	m_pCmdSite->Terminate ();

	*pIsHandled = VARIANT_TRUE;
	return S_OK;
}


//
// Handles OnSelectionChange () event. Use it to handle any selection changes.
//

HRESULT _stdcall CDrawTriangleCommand::OnSelectionChange (void)
{
	// This addon command sample provides no implementation
	return S_OK;
}


//
// Handles OnTerminate () event. Do any internal cleanup here. 
//
    
HRESULT _stdcall CDrawTriangleCommand::OnTerminate (void)
{
	// This addon command sample provides no implementation
	return S_OK;
}


//
// Handles On3DRender () event. Notice how addon command displays its graphics by first calling Begin3DDisplay and using the returned COM interface to draw its triangle.
//
HRESULT _stdcall CDrawTriangleCommand::On3DRender(void)
{
	IUnknown* pUnkDisplayContext = NULL;
	IADAddOnCanvasDisplay* pCanvasDisplay = NULL;

	// Call Begin3DDisplay () and get a context to render my graphics primitives
	// Clear our add-on's scene graph if it is out-of-date. This will erase stuff drawn earlier by calls to DrawTriangle() as well as DrawScrenText(). If not out of date, we do not clear the scene
	m_pCmdSite->Begin3DDisplay(m_bIsOutOfDate ? true : false, &pUnkDisplayContext);
	pUnkDisplayContext->QueryInterface(&pCanvasDisplay);

	// With Alibre Design's Hoops based rendering engine, the addonn need not redraw its graphics unless it invalidated it.
	// View manipulation operations like pan/rotate/zoom etc should not require a redraw by addon
	if (m_bIsOutOfDate)
	{
		// Draw (redraw) the scene
		DrawTriangle(pCanvasDisplay, m_imageFilePath, m_pCmdSite);

		m_bIsOutOfDate = false;

		// Since we erased the entire scene if m_bIsOutOfDate is true, this would have blown away the sub-segment where we drew the screen based text (see code block below). So, make sure to reset the segment
		m_screenTextSegment = 0;
	}

	// Always redraw view independent text that is based on screen coordinates. This will be drawn in a new child segment under the add-on's "root" segment
	// (Today, Alibre framework does not notify the addon when user reizes the window. Therefore, addon has not opportunity to determine that the screen based text is out of date or not. Hence we always redraw.)
	// 
	// First, get the HWND of AD browser
	long long canvasHandle;
	m_pCmdSite->GetViewportHwnd(&canvasHandle);
	m_browserHWND = (HWND)canvasHandle;
	if (m_browserHWND)
	{
		if (m_screenTextSegment == 0)
		{
			// Create a sub segment to draw the screen text in.
			BSTR myTextSegmentName = SysAllocString(L"Screen Text");
			pCanvasDisplay->AddSubSegment(NULL, myTextSegmentName, &m_screenTextSegment);
			SysFreeString(myTextSegmentName);
		}
		else
		{
			// Erase previously drawn text before redrawing
			pCanvasDisplay->ClearSegment(m_screenTextSegment);
		}

		DrawScreenText(pCanvasDisplay, m_pCmdSite, m_browserHWND, m_screenTextSegment);
	}

	// Be sure to release IADAddOnCanvasDisplay interface and to call End3DDisplay() on IADAddOnCommandSite interface before leaving
	pCanvasDisplay->Release();
	m_pCmdSite->End3DDisplay();

	return S_OK;
}

//
// Handles OnRender () event. Deprecated in Alibre Design 2019
//

HRESULT _stdcall CDrawTriangleCommand::OnRender (long ihDC,
	long clipRectOriginX, long clipRectOriginY,
	long clipWidth, long clipHeight)
{
	// This addon command sample provides no implementation
	return S_OK;
}

//
// This function receives the IADAddOnCommandSite object
//

HRESULT _stdcall CDrawTriangleCommand::putref_CommandSite(/* [in] */ IADAddOnCommandSite *pSite)
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState());

	try
	{
		if (pSite)
		{
			// Store this command's command site so that we can later call back into Alibre
			pSite->QueryInterface (&m_pCmdSite);
		}
	}
	catch (...)
	{
		AfxMessageBox ("Exception caught in CDrawTriangleCommand::putref_CommandSite");
	}
	return S_OK;
}


//
// Handles OnShowUI() event. 
//

HRESULT _stdcall CDrawTriangleCommand::OnShowUI (__int64 hWnd)
{
	// This addon command sample provides no implementation
	return S_OK;
}


//
// Allows addon command to specify the bounding box of its graphics data so that they can be included in the view volume.
//
HRESULT _stdcall CDrawTriangleCommand::get_Extents (/*[out,retval]*/ SAFEARRAY **pResult)
{
	// This addon command sample provides no implementation
	return S_FALSE;
}  

//
// IUnknown and Dispatch related implementation
//
ULONG _stdcall CDrawTriangleCommand::AddRef()
{
	long nRefCount = 0;
	nRefCount = InterlockedIncrement (&m_nRefCount);
	return nRefCount;
}

HRESULT _stdcall CDrawTriangleCommand::QueryInterface(REFIID riid, void **ppObj)
{

	if (riid == IID_IUnknown)
	{
		*ppObj = static_cast <IUnknown *> (this);
		AddRef();
		return S_OK;
	}

	if (riid == __uuidof(IAlibreAddOnCommand))
	{
		*ppObj = static_cast <IAlibreAddOnCommand *>(this);
		AddRef();
		return S_OK;
	}

	// If control reaches here then, let the client 
	// know that we do not satisfy the required interface.

	*ppObj = NULL;
	return E_NOINTERFACE;
}

ULONG _stdcall CDrawTriangleCommand::Release()

{
	long nRefCount = 0;
	nRefCount = InterlockedDecrement (&m_nRefCount);
	if (nRefCount == 0) delete this;
	return nRefCount;
}


long _stdcall  CDrawTriangleCommand::GetTypeInfo(
	UINT iTInfo,
	LCID lcid,
	ITypeInfo FAR* FAR* ppTInfo)
{
	*ppTInfo = NULL;

	if (iTInfo != 0)
		return ResultFromScode(DISP_E_BADINDEX);

	m_ptinfo->AddRef();
	*ppTInfo = m_ptinfo;

	return NOERROR;
}


long _stdcall CDrawTriangleCommand::GetTypeInfoCount(UINT FAR* pctinfo)
{
	*pctinfo = 1;
	return NOERROR;
}


long _stdcall  CDrawTriangleCommand::Invoke(
	DISPID dispidMember,
	REFIID riid,
	LCID lcid,
	WORD wFlags,
	DISPPARAMS FAR* pDispParams,
	VARIANT FAR* pVarResult,
	EXCEPINFO FAR* pExcepInfo,
	UINT FAR* puArgErr)
{
	return DispInvoke(
		this, m_ptinfo,
		dispidMember, wFlags, pDispParams,
		pVarResult, pExcepInfo, puArgErr);
}


long _stdcall  CDrawTriangleCommand::GetIDsOfNames(
	REFIID riid,
	OLECHAR FAR* FAR* rgszNames,
	UINT cNames,
	LCID lcid,
	DISPID FAR* rgDispId)
{
	return DispGetIDsOfNames(m_ptinfo, rgszNames, cNames, rgDispId);
}

