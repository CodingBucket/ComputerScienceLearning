#include <iostream>

using namespace std;

class NewClass{
    public:
        void newMethod(){
            cout << "print in new method";
        }
};

int main()
{
    NewClass newObject;
    newObject.newMethod();
    return 0;
}



