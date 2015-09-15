#pragma once

// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the BASICLIBRARY_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// BASICLIBRARY_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef BASICLIBRARY_EXPORTS
#define BASEFOO_API __declspec(dllexport)
#else
#define BASEFOO_API __declspec(dllimport)
#endif

#include <iostream>

// This class is exported from the BasicLibrary.dll
class BASEFOO_API BaseFoo {
public:
	BaseFoo();
	BaseFoo(const BaseFoo &);
	virtual void DoSomething();
	~BaseFoo();
};

