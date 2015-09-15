#pragma once

#ifdef BASICLIBRARY_EXPORTS
#define DERIVEDFOO_API __declspec(dllexport)
#else
#define DERIVEDFOO_API __declspec(dllimport)
#endif

#include "BaseFoo.h"

// This class is exported from the BasicLibrary.dll
class DERIVEDFOO_API DerivedFoo : public BaseFoo {
public:
	DerivedFoo();
	DerivedFoo(const DerivedFoo &);
	void DoSomething() override;
	~DerivedFoo();
};

