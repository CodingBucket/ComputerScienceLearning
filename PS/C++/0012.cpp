#include <iostream>

using namespace std;

int main()
{
    double A, B, C;
    double PI = 3.14159;

    cin >> A >> B >> C;

    double TRIANGULO = (1.0/2) * A * C;
    double CIRCULO   = PI * (C * C);
    double TRAPEZIO  = (1.0/2) * (A+B) * C;
    double QUADRADO  = B * B;
    double RETANGULO = A * B;

    cout.precision(3);
    cout << "TRIANGULO: " << fixed << TRIANGULO << "\n";
    cout << "CIRCULO: " << fixed << CIRCULO << "\n";
    cout << "TRAPEZIO: " << fixed << TRAPEZIO << "\n";
    cout << "QUADRADO: " << fixed << QUADRADO << "\n";
    cout << "RETANGULO: " << fixed << RETANGULO << "\n";

    return 0;
}

