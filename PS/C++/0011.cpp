#include <iostream>

using namespace std;

int main()
{
    double R;

    cin >> R;

    double VOLUME = (4.0/3) * 3.14159 * (R * R * R);

    cout.precision(3);
    cout << "VOLUME = " << fixed << VOLUME << "\n";

    return 0;
}

