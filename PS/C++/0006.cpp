include <iostream>

using namespace std;

int main()
{
    double A;
    double B;
    double C;
    cin >> A;
    cin >> B;
    cin >> C;
    double MEDIA = ( (A * 2) + (B * 3) + (C * 5) ) / (2 + 3 + 5);
    cout.precision(1);
    cout << "MEDIA = " << fixed << MEDIA << "\n";
    return 0;
}

