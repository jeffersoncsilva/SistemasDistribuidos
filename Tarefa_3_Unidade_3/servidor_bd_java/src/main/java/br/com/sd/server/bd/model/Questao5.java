package br.com.sd.server.bd.model;

public class Questao5 {
    private Long id;
    private int idade;
    private String nome;

    public Questao5(Long id, int idade, String nome) {
        this.id = id;
        this.idade = idade;
        this.nome = nome;
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

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }
}
