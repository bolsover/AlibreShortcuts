#ifndef __ADDONSUPPORT_H__
#define __ADDONSUPPORT_H__


struct D3DXMATRIX {
    float m[4][4];

    D3DXMATRIX() {
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                m[i][j] = (i == j) ? 1.0f : 0.0f;  // Identity matrix
    }
};

D3DXMATRIX D3DXMatrixTranslation(float x, float y, float z);


const int		nMAIN_MENUS_COUNT					= 2; 
const int		nROOT_MENU_ID						= 100;
const int		nPOST_RENDER_MENU_ID				= 101;
const int		nOVERRIDE_RENDER_MENU_ID			= 102;

const CString	cStrROOT_MENU						= "DX Triangle";
const CString	cStrPOST_RENDER_MENU				= "Post Render";
const CString	cStrOVERRIDE_RENDER_MENU			= "Override Render";

const int		SLEEP_TIME							= 50;
const int		nTRIANGLE_SIZE						= 5;

template<typename T> HRESULT getSafeArrayFromArray (/*IN*/ T* pIntBuffer,
							   /*IN*/ long size,
							   /*IN*/ enum VARENUM VT_Size,
							   /*OUT*/SAFEARRAY** ppSa);

#endif