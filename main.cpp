#include <iostream>
#include <iomanip> 
using namespace std;
int main() {
  int A, B;

  cout <<"Digite um valor"<< endl;
  cin >> A;
  cout <<"Digite outro valor para ver se estes são múltiplos"<< endl;
  cin >> B;
  
  if (A%B==0){
    cout <<"Eles são múltiplos"<< endl;
  }
  else if (B%A==0){
   cout <<"Eles são múltiplos"<< endl;
  }
  else {
    cout <<"Eles não são múltiplos"<< endl;
  }
  
  return 0;
}