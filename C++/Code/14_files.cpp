#include <iostream>
#include <fstream>

using namespace std;

int main()
{
    ofstream newFile;
    newFile.open("text.txt");

    newFile << "Write something in the file";
    newFile.close();
}



