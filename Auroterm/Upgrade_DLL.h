// Upgrade_DLL.h : Upgrade_DLL DLL 的主要標頭檔
//

#pragma once

#ifndef __AFXWIN_H__
	#error "對 PCH 包含此檔案前先包含 'stdafx.h'"
#endif

#include "resource.h"		// 主要符號

#define VendorId		0x1d50
#define DeviceId		0x8532

// Boot loader space
#define	DP_STANDBY				0x0000
#define	DP_COMMAND				0x0002
#define	DP_MNM1221_STATE		0x000a

#define DP_WR_ADR				0x0c64
#define DP_WR_DATA				0x0c68
#define DP_TOTAL_WORD			0x0c72
#define DP_XchangeComData_FLAG  0x3416
#define DP_Magic_Word_01		0x3418
#define DP_Magic_Word_02		0x341a
#define DP_Upgrade_Mode			0x341c

#define CMD_WR_DATA				98
#define CMD_UPGRADE				99

// APP space
#define DP_VERSION				0x0002
#define DP_VERSION2				0x0816
#define	DP_APP_CMD				0x000c

#define CMD_RESET				1


// CUpgrade_DLLApp
// 這個類別的實作請參閱 Upgrade_DLL.cpp
//

class CUpgrade_DLLApp : public CWinApp
{
public:
	CUpgrade_DLLApp();

// 覆寫
public:
	virtual BOOL InitInstance();

	DECLARE_MESSAGE_MAP()
};


class __declspec(dllexport) UpgradeDll;
class UpgradeDll
{
public:
     UpgradeDll(){};
     virtual ~UpgradeDll(){};
    int Start(int BoardNo);
};

#define DLLEXPORT __declspec(dllexport)  //定義巨集DLLEXPORT(可自行更改名字), 在方法的前面，將ＤＬＬ的方法做輸出
extern "C"{
DLLEXPORT int Start(int BoardNo);
}