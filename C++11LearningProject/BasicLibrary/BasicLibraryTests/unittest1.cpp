#include "stdafx.h"
#include "CppUnitTest.h"
#include <iostream>
#include "..\BasicLibrary\BaseFoo.h"
#include "..\BasicLibrary\DerivedFoo.h"
#include "..\BasicLibrary\Bar.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace BasicLibraryTests
{		
	TEST_CLASS(UnitTest1)
	{
	public:

		TEST_METHOD(CopyConstructorAutoIteratorVersusAutoReference)
		{
			auto foo = { 3, 4, 5, 6 };
			int start = 3;
			// This would call the copy constructor if this was a class!
			for each (auto var in foo)
			{
				Assert::AreEqual(start++, var, L"Weren't equal!", LINE_INFO());
			}

			start = 3;
			// This wouldn't call the copy constructor, because we are asking for the reference!
			for each (auto& var in foo)
			{
				Assert::AreEqual(start++, var, L"Weren't equal!", LINE_INFO());
			}
		}

		TEST_METHOD(SlicingExample)
		{
			DerivedFoo foo;

			// This prints out the BaseFoo DoSomething() because the object was sliced - pass by value so it was copied into a new object of BaseFoo type
			DoThingOnFooByValue(foo);

			// This one is copied by reference, so this will work properly and call the derived method.
			DoThingOnFooByReference(foo);

			// TODO: Another slicing example would be storing DerivedFoo objects in an array of BaseFoo
		}

		void DoThingOnFooByValue(BaseFoo foo) {
			foo.DoSomething();
		}

		void DoThingOnFooByReference(BaseFoo& foo) {
			foo.DoSomething();
		}

		TEST_METHOD(TemplateMatchingDemo)
		{
			int i = 42;
			const int j = 1337;

			// This will call the Template class T match because it is a closer match - the int is not a const.
			MatchInt(i);

			// This will call the non-class one with the const, b/c this is const.
			MatchInt(j);
		}

		template <class T> void MatchInt(T &i) { std::cout << 1; }

		template <> void MatchInt(const int &i) { std::cout << 2; }

		// This is not specific to testing any C++11 feature, but was interesting to note.
		TEST_METHOD(PointerDefaultGarbageTrue)
		{
			void * p = &p;

			// This will be true because the garbage pointer will not be null!
			bool valAsBool = bool(p);
			Assert::AreEqual(true, valAsBool);
		}

		TEST_METHOD(StaticCastVsDynamicCastBasics) 
		{
			BaseFoo* baseFoo = new BaseFoo();

			// Behavior here is undefined - we'll get back a DerivedFoo* but beware actually trying to use it as a DerivedFoo.
			DerivedFoo* derivedFooStatic = static_cast<DerivedFoo*>(baseFoo);

			// This line would not compile - static_cast is a compile-time check and since these types aren't related, this wouldn't compile.
			//Bar* baseFooAsBarPointer = static_cast<Bar*>(baseFoo);

			// Here we know that the result of this cast will be equivalent to nullptr - these types aren't related, but this does compile.
			Bar* baseFooAsBarPointerDynamic = dynamic_cast<Bar*>(baseFoo);

			Assert::IsTrue(baseFooAsBarPointerDynamic == nullptr);

			// Here we know that the result of this cast will be equivalent to nullptr - since it really isn't a DerivedFoo.
			DerivedFoo* derivedFooDynamic = dynamic_cast<DerivedFoo*>(baseFoo);

			Assert::IsTrue(derivedFooDynamic == nullptr);
		}
	};
}