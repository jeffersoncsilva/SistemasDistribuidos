package br.com.sd.server.bd.dao;

import br.com.sd.server.bd.infra.ConnectionFactory;
import br.com.sd.server.bd.model.Questao3;
import com.google.gson.Gson;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

public class Questao3DAO implements IQuestaoDAO<Questao3> {
    @Override
    public Questao3 save(Questao3 q) {
        System.out.println("Função não implementada.");
        return q;
    }

    @Override
    public Questao3 update(Questao3 q) {
        System.out.println("Função não implementada.");
        return q;
    }

    @Override
    public List<Questao3> findAll() {
        String sql = "select * from questao03";
        List<Questao3> q = new ArrayList<>();
        try{
            try(Connection con = ConnectionFactory.getConnection()){
                PreparedStatement p = con.prepareStatement(sql);
                ResultSet rs = p.executeQuery();
                while(rs.next()){
                    Long id = rs.getLong("id");
                    int n1 = rs.getInt("n1");
                    int n2 = rs.getInt("n2");
                    int n3 = rs.getInt("n3");
                    q.add(new Questao3(id, n1, n2, n3));
                }
            }
        }catch (SQLException ex){
            throw new RuntimeException(ex);
        }
        return q;
    }

    @Override
    public Optional<Questao3> findById(Long id) {
        System.out.println("Função não implementada.");
        return Optional.empty();
    }

    @Override
    public String findAllJsonFormat() {
        List<Questao3> all = findAll();
        Gson gson = new Gson();
        String json = gson.toJson(all);
        return json;
    }

    @Override
    public String findByIdJsonFormat(Long id) {
        System.out.println("Função não implementada.");
        return null;
    }
}
