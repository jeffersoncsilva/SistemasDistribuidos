package br.com.sd.server.bd.model;

public class Questao1 {
    private Long id;
    private String nome;
    private Cargo cargo;
    private double salario;

    public Questao1(Long id, String nome, Cargo cargo, double salario) {
        this.id = id;
        this.nome = nome;
        this.cargo = cargo;
        this.salario = salario;
    }

    public String toString(){
        return "ID: " + id + " - Nome: " + nome + " - Cargo: "+ cargo.toString() + " - Salario: " + salario;
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

    public Cargo getCargo() {
        return cargo;
    }

    public void setCargo(Cargo cargo) {
        this.cargo = cargo;
    }

    public double getSalario() {
        return salario;
    }

    public void setSalario(double salario) {
        this.salario = salario;
    }
}
