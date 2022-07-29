package br.com.sd.server.bd.model;

public class Questao9 {
    private Long id;
    private String valor;
    private String naipe;

    public Questao9(Long id, String valor, String naipe) {
        this.id = id;
        this.valor = valor;
        this.naipe = naipe;
    }

    public Questao9(String valor, String naipe) {
        this.valor = valor;
        this.naipe = naipe;
    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getValor() {
        return valor;
    }

    public void setValor(String valor) {
        this.valor = valor;
    }

    public String getNaipe() {
        return naipe;
    }

    public void setNaipe(String naipe) {
        this.naipe = naipe;
    }
}
