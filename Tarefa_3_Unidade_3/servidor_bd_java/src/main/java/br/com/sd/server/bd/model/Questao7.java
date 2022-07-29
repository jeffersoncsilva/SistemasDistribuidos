package br.com.sd.server.bd.model;

public class Questao7 {
    private Long id;
    private int idade, tempo_trabalho;

    public Questao7(Long id, int idade, int tempo_trabalho) {
        this.id = id;
        this.idade = idade;
        this.tempo_trabalho = tempo_trabalho;
    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }

    public int getTempo_trabalho() {
        return tempo_trabalho;
    }

    public void setTempo_trabalho(int tempo_trabalho) {
        this.tempo_trabalho = tempo_trabalho;
    }
}
