/* https://www.urionlinejudge.com.br/judge/en/problems/view/1002 */

#include <iostream>

using namespace std;

int main()
{
    double R;
    double PI = 3.14159;
    cin >> R;
    double A = PI * (R * R);
    cout.precision(4);
    cout << "A=" << fixed << A << "\n";
    return 0;
}

