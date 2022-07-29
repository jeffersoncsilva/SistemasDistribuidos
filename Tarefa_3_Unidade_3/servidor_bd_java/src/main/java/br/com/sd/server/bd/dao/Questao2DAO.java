package br.com.sd.server.bd.dao;

import br.com.sd.server.bd.infra.ConnectionFactory;
import br.com.sd.server.bd.model.Questao2;
import com.google.gson.Gson;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

public class Questao2DAO implements IQuestaoDAO<Questao2>{

    @Override
    public Questao2 save(Questao2 q) {
        System.out.println("Operação não implementada.");
        return q;
    }

    @Override
    public Questao2 update(Questao2 q) {
        System.out.println("Operação não implementada.");
        return q;
    }

    @Override
    public List<Questao2> findAll() {
        String sql = "select * from questao02";
        List<Questao2> q = new ArrayList<>();
        try{
            try(Connection con = ConnectionFactory.getConnection()){
                PreparedStatement p = con.prepareStatement(sql);
                ResultSet rs = p.executeQuery();
                while(rs.next()){
                    Long id = rs.getLong("id");
                    String nome = rs.getString("nome");
                    String sexo = rs.getString("sexo");
                    int idade = rs.getInt("idade");
                    q.add(new Questao2(id, nome, sexo, idade));
                }
            }
        }catch (SQLException ex){
            throw new RuntimeException(ex);
        }
        return q;
    }

    @Override
    public Optional findById(Long id) {

        return Optional.empty();
    }

    @Override
    public String findAllJsonFormat() {
        List<Questao2> all = findAll();
        Gson gson = new Gson();
        String json = gson.toJson(all);
        return json;
    }

    @Override
    public String findByIdJsonFormat(Long id) {
        return null;
    }
}
