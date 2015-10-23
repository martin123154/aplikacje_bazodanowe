
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
#include <time.h>
#define MAX 60000l
#define MLD 1000000000.0
#define MAX_LEN 223200

void ObliczLPSTab(char *P, int m, int *longestprefixsuffix){ 
    int length = 0, i;
    longestprefixsuffix[0] = 0;
    i = 1;
    while (i < m){ 
        if (P[i] == P[length]){ 
            length++; 
            longestprefixsuffix[i] = length;
            i++; 
        } 
		else{
            if (length != 0)
                length = longestprefixsuffix[length - 1]; 
            else{
                longestprefixsuffix[i] = 0; 
                i++;
            }
        }
    }
}

void KMP(char *pat, char *txt){
    int m = strlen(pat); 
    int n = strlen(txt);
    int *longestprefixsuffix = (int *) malloc(sizeof (int)*m); 
    int j = 0;
    ObliczLPSTab(pat, m, longestprefixsuffix); 
    int i = 0;

    while (i < n){ 
        if (pat[j] == txt[i]){ 
            j++; 
            i++; 
        }
        if (j == m){ 
            printf("Wrzorzec wystepuje z przesunieciem %d\n", i - j);
            j = longestprefixsuffix[j - 1]; 
        } 
		else if (pat[j] != txt[i]){ 
            if (j != 0) 
                j = longestprefixsuffix[j - 1];
            else
                i = i + 1;
        }
    }
    free(longestprefixsuffix);
}

void RK(char *pat, char *txt, int d, int q) {
    int m = strlen(pat); 
    int n = strlen(txt); 
    int i, j, p = 0, t = 0, h = 1;

    for (i = 0; i < m - 1; i++) 
        h = (h * d) % q; 
    for (i = 0; i < m; i++){ 
        p = (d * p + pat[i]) % q; 
        t = (d * t + txt[i]) % q;
    }
    
    for (i = 0; i <= n - m; i++){ /
        if (p == t){ 
            for (j = 0; j < m; j++) 
                if (txt[i + j] != pat[j]) 
                    break; 
            if (j == m) 
                printf("Wrzorzec wystepuje z przesunieciem %d\n", i);
        }
        if (i < n - m){ 
            t = (d * (t - txt[i] * h) + txt[i + m]) % q; 
            if (t < 0)
                t = (t + q);
        }
    }
}

void NaiwnySposobSzukaniaWzorca(char *T, char *P){
    int m = strlen(P); 
    int n = strlen(T);
    int s;
    for (s = 0; s < n - m + 1; s++){ 
        char AktualnieWyciety[MAX_LEN] = ""; 
        strncpy(AktualnieWyciety, T + s, m);
        if (strcmp(AktualnieWyciety, P) == 0) printf("Wrzorzec wystepuje z przesunieciem %d\n", s);
    }
}

void WczytajDoTabeli(char *Tablica, char *PlikZrodlowy){
    FILE *plik; 
    
    if ((plik = fopen(PlikZrodlowy, "r")) == NULL){ 
        printf("Nie moge otworzyc pliku %s\n", PlikZrodlowy); 
    }

    int znak = getc(plik); 
    while (znak != EOF){ 
        char litera[4] = "";
        sprintf(litera, "%c", (char) znak); 
        strcat(Tablica, litera); 
        znak = getc(plik); 
    }
    fclose(plik);
}

int main(int argc, char** argv){
    char T[MAX_LEN] = ""; 
    char P[MAX_LEN] = "";
    WczytajDoTabeli(T, "tekst.txt"); 
    WczytajDoTabeli(P, "wzorzec.txt"); 

    struct timespec tp0, tp1; 
    double Tn;

    printf("\tSposob Naiwny\n");
    clock_gettime(CLOCK_PROCESS_CPUTIME_ID, &tp0); 
    NaiwnySposobSzukaniaWzorca(T, P); 
    clock_gettime(CLOCK_PROCESS_CPUTIME_ID, &tp1);
    Tn = (tp1.tv_sec + tp1.tv_nsec / MLD)-(tp0.tv_sec + tp0.tv_nsec / MLD);
    printf("\tczas: %3.5lf \n", Tn); 


    printf("\tSposob Rabina-Karpa\n");
    clock_gettime(CLOCK_PROCESS_CPUTIME_ID, &tp0); 
    RK(P, T, 128, 27077); 
    clock_gettime(CLOCK_PROCESS_CPUTIME_ID, &tp1);
    Tn = (tp1.tv_sec + tp1.tv_nsec / MLD)-(tp0.tv_sec + tp0.tv_nsec / MLD); 
    printf("\tczas: %3.5lf \n", Tn); 


    printf("\tSposob Knutha Morrisa Pratta\n"); 
    clock_gettime(CLOCK_PROCESS_CPUTIME_ID, &tp0); 
    KMP(P, T); //wywolanie funkcji
    clock_gettime(CLOCK_PROCESS_CPUTIME_ID, &tp1); 
    Tn = (tp1.tv_sec + tp1.tv_nsec / MLD)-(tp0.tv_sec + tp0.tv_nsec / MLD);
    printf("\tczas: %3.5lf \n", Tn); 


    return 0;
}
