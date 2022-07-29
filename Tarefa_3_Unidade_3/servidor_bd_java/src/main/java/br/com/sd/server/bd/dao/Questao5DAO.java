package br.com.sd.server.bd.dao;

import br.com.sd.server.bd.infra.ConnectionFactory;
import br.com.sd.server.bd.model.Questao4;
import br.com.sd.server.bd.model.Questao5;
import com.google.gson.Gson;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

public class Questao5DAO implements IQuestaoDAO<Questao5> {
    @Override
    public Questao5 save(Questao5 q) {
        return null;
    }

    @Override
    public Questao5 update(Questao5 q) {
        return null;
    }

    @Override
    public List<Questao5> findAll() {
        String sql = "select * from questao05";
        List<Questao5> q = new ArrayList<>();
        try{
            try(Connection con = ConnectionFactory.getConnection()){
                PreparedStatement p = con.prepareStatement(sql);
                ResultSet rs = p.executeQuery();
                while(rs.next()){
                    Long id = rs.getLong("id");
                    int idade = rs.getInt("idade");
                    String nome = rs.getString("nome");
                    q.add(new Questao5(id,idade, nome));
                }
            }
        }catch (SQLException ex){
            throw new RuntimeException(ex);
        }
        return q;
    }

    @Override
    public Optional<Questao5> findById(Long id) {
        return Optional.empty();
    }

    @Override
    public String findAllJsonFormat() {
        List<Questao5> all = findAll();
        Gson gson = new Gson();
        String json = gson.toJson(all);
        return json;
    }

    @Override
    public String findByIdJsonFormat(Long id) {
        return null;
    }
}
