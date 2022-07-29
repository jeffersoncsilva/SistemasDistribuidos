package br.com.sd.server.bd.model;

public class Questao8 {
    private Long id;
    private Double salario_medio;

    public Questao8(Long id, Double salario_medio) {
        this.id = id;
        this.salario_medio = salario_medio;
    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public Double getSalario_medio() {
        return salario_medio;
    }

    public void setSalario_medio(Double salario_medio) {
        this.salario_medio = salario_medio;
    }
}
