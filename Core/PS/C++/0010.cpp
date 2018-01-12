#include <iostream>

using namespace std;

int main()
{
    int code, code1, unit, unit1;
    double price, price1;

    cin >> code >> unit >> price;
    cin >> code1 >> unit1 >> price1;

    double total = (unit * price) + (unit1 * price1);

    cout.precision(2);
    cout << "VALOR A PAGAR: R$ " << fixed << total << "\n";

    return 0;
}

