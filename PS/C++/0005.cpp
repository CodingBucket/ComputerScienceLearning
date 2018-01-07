#include <iostream>

using namespace std;

int main()
{
    double A;
    double B;
    cin >> A;
    cin >> B;
    double MEDIA = ( (A * 3.5) + (B * 7.5) ) / (3.5 + 7.5);
    cout.precision(5);
    cout << "MEDIA = " << fixed << MEDIA << "\n";
    return 0;
}


