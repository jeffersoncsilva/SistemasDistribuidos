package br.com.sd.server.bd.dao;

import br.com.sd.server.bd.infra.ConnectionFactory;
import br.com.sd.server.bd.model.Questao3;
import br.com.sd.server.bd.model.Questao4;
import com.google.gson.Gson;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

public class Questao4DAO implements IQuestaoDAO<Questao4>{
    @Override
    public Questao4 save(Questao4 q) {
        System.out.println("Não implementado ainda.");
        return q;
    }

    @Override
    public Questao4 update(Questao4 q) {
        System.out.println("Não implementado ainda.");
        return q;
    }

    @Override
    public List<Questao4> findAll() {
        String sql = "select * from questao04";
        List<Questao4> q = new ArrayList<>();
        try{
            try(Connection con = ConnectionFactory.getConnection()){
                PreparedStatement p = con.prepareStatement(sql);
                ResultSet rs = p.executeQuery();
                while(rs.next()){
                    Long id = rs.getLong("id");
                    int altura = rs.getInt("altura");
                    String sexo = rs.getString("sexo");
                    q.add(new Questao4(id,altura, sexo));
                }
            }
        }catch (SQLException ex){
            throw new RuntimeException(ex);
        }
        return q;

    }

    @Override
    public Optional<Questao4> findById(Long id) {
        return Optional.empty();
    }

    @Override
    public String findAllJsonFormat() {
        List<Questao4> all = findAll();
        Gson gson = new Gson();
        String json = gson.toJson(all);
        return json;
    }

    @Override
    public String findByIdJsonFormat(Long id) {
        System.out.println("Não implementado ainda.");
        return null;
    }
}
