package br.com.sd.server.bd.model;

public class Questao6 {
    private Long id;
    private String nome, nivel;
    private Double salario;
    private int dependentes;

    public Questao6(Long id, String nome, String nivel, Double salario, int dependentes) {
        this.id = id;
        this.nome = nome;
        this.nivel = nivel;
        this.salario = salario;
        this.dependentes = dependentes;
    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getNivel() {
        return nivel;
    }

    public void setNivel(String nivel) {
        this.nivel = nivel;
    }

    public Double getSalario() {
        return salario;
    }

    public void setSalario(Double salario) {
        this.salario = salario;
    }

    public int getDependentes() {
        return dependentes;
    }

    public void setDependentes(int dependentes) {
        this.dependentes = dependentes;
    }
}
