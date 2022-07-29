package br.com.sd.server.bd.dao;

import java.util.List;
import java.util.Optional;

public interface IQuestaoDAO<T> {
    T save(T q);
    T update(T q);
    List<T> findAll();
    Optional<T> findById(Long id);
    String findAllJsonFormat();
    String findByIdJsonFormat(Long id);
}
