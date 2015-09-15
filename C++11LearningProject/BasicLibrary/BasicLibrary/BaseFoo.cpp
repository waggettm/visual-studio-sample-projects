#include "stdafx.h"
#include "BaseFoo.h"


BaseFoo::BaseFoo()
{
	std::cout << "BaseRegularConstructor";
}

BaseFoo::BaseFoo(const BaseFoo &)
{
	std::cout << "BaseCopyConstructor";
}

void BaseFoo::DoSomething()
{
	std::cout << "BaseDoSomething";
}

BaseFoo::~BaseFoo()
{
}