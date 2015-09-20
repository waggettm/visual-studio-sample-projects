#pragma once

// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the BASICLIBRARY_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// BASICLIBRARY_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef BASICLIBRARY_EXPORTS
#define BAR_API __declspec(dllexport)
#else
#define BAR_API __declspec(dllimport)
#endif

// This class is exported from the BasicLibrary.dll
class BAR_API Bar {
public:
	Bar();

	// Method to sum up x & y and return the result plus the bar factor (42).
	int BarAdd(int x, int y);
	~Bar();
};
