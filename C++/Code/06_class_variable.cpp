#include <iostream>
#include <string>

using namespace std;

class NewClass{
    public:
        void setName(string parem){
            name = parem;
        }
        string getName(){
            return name;
        }
    private:
        string name;
};

int main()
{
    NewClass newObject;
    newObject.setName("Hasan");
    cout << newObject.getName();
    return 0;
}



