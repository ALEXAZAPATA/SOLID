#include <iostream>
#include <string>
using namespace std;

class Animal {
public:
    string nombre;

    Animal(string nombre) : nombre(nombre) {
        cout << "Animal constructor" << endl;
    }

    virtual void andar() {
        cout << nombre << " esta andando" << endl;
    }
};

class Perro : virtual public Animal {
public:
    Perro(string nombre) : Animal(nombre) {}

    void ladrar() {
        cout << nombre << " esta ladrando" << endl;
    }
};

int main() {
    Perro perro1("Pako");

    perro1.ladrar();
    perro1.andar();


};

class Nadador : public Animal {
public:
    void andar() {
        cout << nombre << " esta nadando" << endl;
    }
};
class Volador : public Animal {
public:
    void volar() {
        cout << nombre << " esta volando" << endl;
    }
};






