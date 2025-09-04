using System.Diagnostics.Eventing.Reader;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int start;
    public int end;
    public int more;
    public KeyCode letter;

    private void Update()
    {
        if (Input.GetKeyUp(letter))
        {
            if (more <= 0 || end < start)
            {
                print("coglione hai sbagliato");
            }
            if (more <= 0)
            {
                print("coglione hai sbagliato incremento");
                more = 1;
            }
            if(end < start)
            {
                print("coglione hai sbagliato finale");
                end = start*2;
            }

                ForLoop(start, end, more);
        }
    }
    public void ForLoop(int _start, int _end, int _more)
    {
        print("la mia i inizia con " + _start);
        print("la mia i raggiunge " + _end);
        print("la mia i incrementa di " + _more);

        for (int i = _start; i < _end; i += _more)
        {
            print("la mia i vale " + i);

        }
    }
}
