// Upgrade_DLL.h : Upgrade_DLL DLL ���D�n���Y��
//

#pragma once

#ifndef __AFXWIN_H__
	#error "�� PCH �]�t���ɮ׫e���]�t 'stdafx.h'"
#endif

#include "resource.h"		// �D�n�Ÿ�

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
// �o�����O����@�аѾ\ Upgrade_DLL.cpp
//

class CUpgrade_DLLApp : public CWinApp
{
public:
	CUpgrade_DLLApp();

// �мg
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

#define DLLEXPORT __declspec(dllexport)  //�w�q����DLLEXPORT(�i�ۦ���W�r), �b��k���e���A�N�Ңڢڪ���k����X
extern "C"{
DLLEXPORT int Start(int BoardNo);
}