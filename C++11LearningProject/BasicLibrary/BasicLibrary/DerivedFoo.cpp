#include "stdafx.h"
#include "DerivedFoo.h"


DerivedFoo::DerivedFoo()
{
	std::cout << "DerivedRegularConstructor";
}

DerivedFoo::DerivedFoo(const DerivedFoo &)
{
	std::cout << "DerivedCopyConstructor";
}

void DerivedFoo::DoSomething()
{
	std::cout << "DerivedDoSomething";
}

DerivedFoo::~DerivedFoo()
{
}