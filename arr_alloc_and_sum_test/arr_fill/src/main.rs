use std::time::{Instant};

fn main() {
    let mut a = Vec::new();

    for i in 0..20000000 as i64 {
        a.push(i);
    }

    let mut sum: i64  = 0;
    let len = a.len();

    let start = Instant::now();

    for i in 0..len {
        sum+= a[i];
    }

    let duration_1 = start.elapsed();
    println!("{:?}", duration_1);
    println!("{:?}", sum);
}
