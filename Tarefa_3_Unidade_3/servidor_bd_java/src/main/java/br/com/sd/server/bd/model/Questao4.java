package br.com.sd.server.bd.model;

public class Questao4 {
    private Long id;
    private int altura;
    private String sexo;

    public Questao4(Long id, int altura, String sexo) {
        this.id = id;
        this.altura = altura;
        this.sexo = sexo;
    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public int getAltura() {
        return altura;
    }

    public void setAltura(int altura) {
        this.altura = altura;
    }

    public String getSexo() {
        return sexo;
    }

    public void setSexo(String sexo) {
        this.sexo = sexo;
    }
}
