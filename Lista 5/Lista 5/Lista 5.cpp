#include <stdio.h>
#include <stdlib.h>

// Definição do tipo link como ponteiro para struct node
typedef struct node* link;

// Definição da estrutura node
struct node {
    int item;
    link next; // Ponteiro para o próximo nó
};

// Função para criar a lista circular com cabeça
link criarLista() {
    link cabeca = (link)malloc(sizeof(struct node));
    cabeca->item = -1; // Valor simbólico para a cabeça
    cabeca->next = cabeca; // Aponta para si mesma
    return cabeca;
}

// Função para inserir um item na lista circular com cabeça
void inserir(link lista, int novoItem) {
    link novoNode = (link)malloc(sizeof(struct node));
    novoNode->item = novoItem;

    link p = lista;
    while (p->next != lista) // Encontrar o último nó
        p = p->next;

    p->next = novoNode;
    novoNode->next = lista; // Aponta para a cabeça
}

// Função para imprimir a lista circular com cabeça
void imprimir(link lista) {
    link p = lista->next; // Pula a cabeça
    printf("Lista: ");
    while (p != lista) {
        printf("%d -> ", p->item);
        p = p->next;
    }
    printf("(cabeça)\n");
}

// Função para resolver o problema de Josephus
int Josephus(int N, int k) {
    link lista = criarLista();
    for (int i = 1; i <= N; i++) {
        inserir(lista, i);
    }

    // Inicializando ponteiros
    link p = lista->next;
    link anterior = lista; // Começa na cabeça

    // Ajusta 'anterior' para o último nó antes de iniciar a eliminação
    while (anterior->next != lista) {
        anterior = anterior->next;
    }

    // Enquanto houver mais de um nó na lista
    while (p->next != p) {
        // Avançar k-1 posições
        for (int i = 1; i < k; i++) {
            anterior = p;
            p = p->next;
        }

        // Remover a pessoa selecionada
        printf("Removendo: %d\n", p->item);
        anterior->next = p->next;
        free(p);
        p = anterior->next; // Atualiza o ponteiro atual
    }

    int sobrevivente = p->item;
    free(p);
    free(lista);
    return sobrevivente;
}

int main(void) {
    int N, k;
    printf("Digite o número de pessoas N: ");
    scanf_s("%d", &N);
    printf("Digite o valor de k: ");
    scanf_s("%d", &k);

    int lider = Josephus(N, k);
    printf("O líder eleito é a pessoa: %d\n", lider);

    return 0;
}
