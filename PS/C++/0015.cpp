#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    double X1, Y1, X2, Y2;

    cin >> X1 >> Y1;
    cin >> X2 >> Y2;

    double XX = pow((X2 - X1),2);
    double YY = pow((Y2 - Y1),2);
    double r = sqrt(XX+YY);

    cout.precision(4);
    cout << fixed << r << "\n";

    return 0;
}

